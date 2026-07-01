using AssetMonitor.Application.Features.Equipment.DTOs;

namespace AssetMonitor.Application.Features.Equipment.Interfaces;

public interface IEquipmentService
{
    Task<EquipmentDto> CreateAsync(CreateEquipmentDto dto);

    Task<List<EquipmentDto>> GetAllAsync();

    Task<EquipmentDto?> GetByIdAsync(Guid id);

    Task<EquipmentDto?> UpdateAsync(
        Guid id,
        UpdateEquipmentDto dto);

    Task DeleteAsync(Guid id);
}