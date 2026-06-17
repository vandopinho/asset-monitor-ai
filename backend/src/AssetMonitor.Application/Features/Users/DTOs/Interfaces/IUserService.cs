using AssetMonitor.Application.Features.Users.DTOs;

namespace AssetMonitor.Application.Features.Users.Interfaces;

public interface IUserService
{
    Task<UserDto> CreateAsync(CreateUserDto dto);

    Task<List<UserDto>> GetAllAsync();

    Task<UserDto?> GetByIdAsync(Guid id);
    Task DeleteAsync(Guid id);
}