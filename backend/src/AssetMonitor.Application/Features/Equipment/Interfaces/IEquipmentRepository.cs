using AssetMonitor.Domain.Entities;

namespace AssetMonitor.Application.Features.Equipment.Interfaces;

using EquipmentEntity = AssetMonitor.Domain.Entities.Equipment;

public interface IEquipmentRepository
{
    Task AddAsync(EquipmentEntity equipment);

    Task<List<EquipmentEntity>> GetAllAsync();

    Task<EquipmentEntity?> GetByIdAsync(Guid id);

    Task UpdateAsync(EquipmentEntity equipment);

    Task SaveChangesAsync();
    Task<EquipmentEntity?> GetBySerialNumberAsync(string serialNumber);
}