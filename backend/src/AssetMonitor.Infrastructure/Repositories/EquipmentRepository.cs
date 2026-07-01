using AssetMonitor.Application.Features.Equipment.Interfaces;
using AssetMonitor.Domain.Entities;
using AssetMonitor.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AssetMonitor.Infrastructure.Persistence.Repositories;

public class EquipmentRepository : IEquipmentRepository
{
    private readonly AppDbContext _context;

    public EquipmentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Equipment equipment)
    {
        await _context.Equipments.AddAsync(equipment);
    }

    public async Task<List<Equipment>> GetAllAsync()
    {
        return await _context.Equipments
            .Where(x => !x.IsDeleted)
            .ToListAsync();
    }

    public async Task<Equipment?> GetByIdAsync(Guid id)
    {
        return await _context.Equipments
            .FirstOrDefaultAsync(x =>
                x.Id == id &&
                !x.IsDeleted);
    }

    public Task UpdateAsync(Equipment equipment)
    {
        _context.Equipments.Update(equipment);

        return Task.CompletedTask;
    }
    public async Task<Equipment?> GetBySerialNumberAsync(string serialNumber)
    {
        return await _context.Equipments
            .FirstOrDefaultAsync(x =>
                x.SerialNumber == serialNumber &&
                !x.IsDeleted);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}