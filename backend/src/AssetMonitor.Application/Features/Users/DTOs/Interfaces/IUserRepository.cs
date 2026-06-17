using AssetMonitor.Domain.Entities;

namespace AssetMonitor.Application.Features.Users.Interfaces;

public interface IUserRepository
{
    Task<User> AddAsync(User user);

    Task<List<User>> GetAllAsync();

    Task<User?> GetByIdAsync(Guid id);

    Task<User?> GetByEmailAsync(string email);

    Task SaveChangesAsync();
}