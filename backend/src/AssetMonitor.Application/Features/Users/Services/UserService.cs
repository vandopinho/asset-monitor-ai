using AssetMonitor.Application.Features.Users.DTOs;
using AssetMonitor.Application.Features.Users.Interfaces;
using AssetMonitor.Domain.Entities;

namespace AssetMonitor.Application.Features.Users.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserDto> CreateAsync(CreateUserDto dto)
    {
        var existingUser = await _repository.GetByEmailAsync(dto.Email);

        if (existingUser != null)
            throw new Exception("User already exists.");

        // Temporário: depois usaremos BCrypt
        var passwordHash = dto.Password;

        var user = new User(
            dto.Name,
            dto.Email,
            passwordHash,
            dto.Role);

        await _repository.AddAsync(user);
        await _repository.SaveChangesAsync();

        return Map(user);
    }

    public async Task<List<UserDto>> GetAllAsync()
    {
        var users = await _repository.GetAllAsync();

        return users.Select(Map).ToList();
    }

    public async Task<UserDto?> GetByIdAsync(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        return user == null ? null : Map(user);
    }

    private static UserDto Map(User user)
    {
        return new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Role = user.Role,
            Active = user.Active
        };
    }
    public async Task DeleteAsync(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        if (user == null)
            throw new Exception("User not found.");

        user.Delete();

        await _repository.UpdateAsync(user);

        await _repository.SaveChangesAsync();
    }
}