using AssetMonitor.Application.DTOs.Auth;
using AssetMonitor.Application.Features.Authentication.DTOs;
using AssetMonitor.Application.Features.Authentication.Interfaces;
using AssetMonitor.Application.Features.Users.Interfaces;
using AssetMonitor.Application.Interfaces;

namespace AssetMonitor.Application.Features.Authentication.Services;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthService(
        IUserRepository userRepository,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<LoginResponseDto?> LoginAsync(
        LoginRequestDto request)
    {
        var user = await _userRepository
            .GetByEmailAsync(request.Email);

        if (user is null)
            return null;

        if (!user.Active || user.IsDeleted)
            return null;

        var validPassword = BCrypt.Net.BCrypt.Verify(
            request.Password,
            user.PasswordHash);

        if (!validPassword)
            return null;

        var token = _jwtTokenGenerator.GenerateToken(
            user.Id,
            user.Email,
            user.Role);

        return new LoginResponseDto
        {
            Token = token,
            ExpiresAt = DateTime.UtcNow.AddMinutes(15),
            User = new UserInfoDto
            {
                Id = user.Id,
                Email = user.Email,
                Role = user.Role
            }
        };
    }
    public async Task<UserInfoDto?> GetCurrentUserAsync(Guid userId)
    {
        var user = await _userRepository.GetByIdAsync(userId);

        if (user is null)
            return null;

        return new UserInfoDto
        {
            Id = user.Id,
            Email = user.Email,
            Role = user.Role
        };
    }
}