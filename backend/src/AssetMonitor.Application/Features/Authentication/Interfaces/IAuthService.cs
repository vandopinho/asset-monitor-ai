using AssetMonitor.Application.Features.Authentication.DTOs;

namespace AssetMonitor.Application.Features.Authentication.Interfaces;

public interface IAuthService
{
    Task<LoginResponseDto?> LoginAsync(LoginRequestDto request);
    Task<UserInfoDto?> GetCurrentUserAsync(Guid userId);
}