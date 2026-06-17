using AssetMonitor.Application.Features.Users.Interfaces;
using AssetMonitor.Domain.Entities;
using AssetMonitor.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AssetMonitor.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User> AddAsync(User user)
    {
        await _context.Users.AddAsync(user);

        return user;
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _context.Users
            .Where(x => !x.IsDeleted)
            .ToListAsync();
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await _context.Users
            .FirstOrDefaultAsync(
                    x => x.Id == id &&
                        !x.IsDeleted);
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _context.Users
            .FirstOrDefaultAsync(
                    x => x.Email == email &&
                        !x.IsDeleted);
    }

    public Task UpdateAsync(User user)
    {
        _context.Users.Update(user);

        return Task.CompletedTask;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}