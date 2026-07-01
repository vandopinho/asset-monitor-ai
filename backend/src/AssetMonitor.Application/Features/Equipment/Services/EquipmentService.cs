using AssetMonitor.Application.Common.Exceptions;
using AssetMonitor.Application.Features.Equipment.DTOs;
using AssetMonitor.Application.Features.Equipment.Interfaces;

using EquipmentEntity = AssetMonitor.Domain.Entities.Equipment;

namespace AssetMonitor.Application.Features.Equipment.Services;

public class EquipmentService : IEquipmentService
{
    private readonly IEquipmentRepository _repository;

    public EquipmentService(IEquipmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<EquipmentDto> CreateAsync(CreateEquipmentDto dto)
    {
        var existingEquipment =
            await _repository.GetBySerialNumberAsync(dto.SerialNumber);

        if (existingEquipment != null)
            throw new EquipmentAlreadyExistsException(dto.SerialNumber);

        var equipment = new EquipmentEntity(
            dto.Name,
            dto.SerialNumber,
            dto.Type,
            dto.UserId);

        await _repository.AddAsync(equipment);
        await _repository.SaveChangesAsync();

        return Map(equipment);
    }

    public async Task<List<EquipmentDto>> GetAllAsync()
    {
        var equipments = await _repository.GetAllAsync();

        return equipments
            .Select(Map)
            .ToList();
    }

    public async Task<EquipmentDto?> GetByIdAsync(Guid id)
    {
        var equipment = await _repository.GetByIdAsync(id);

        if (equipment is null)
            throw new EquipmentNotFoundException(id);

        return Map(equipment);
    }

    public async Task<EquipmentDto?> UpdateAsync(
        Guid id,
        UpdateEquipmentDto dto)
    {
        var equipment = await _repository.GetByIdAsync(id);

        if (equipment is null)
            throw new EquipmentNotFoundException(id);

        var existingEquipment =
            await _repository.GetBySerialNumberAsync(dto.SerialNumber);

        if (existingEquipment != null &&
            existingEquipment.Id != id)
        {
            throw new EquipmentAlreadyExistsException(dto.SerialNumber);
        }

        equipment.Update(
            dto.Name,
            dto.Type,
            dto.Status);

        await _repository.UpdateAsync(equipment);
        await _repository.SaveChangesAsync();

        return Map(equipment);
    }

    public async Task DeleteAsync(Guid id)
    {
        var equipment = await _repository.GetByIdAsync(id);

        if (equipment is null)
            throw new EquipmentNotFoundException(id);

        equipment.Deactivate();

        await _repository.UpdateAsync(equipment);
        await _repository.SaveChangesAsync();
    }

    private static EquipmentDto Map(EquipmentEntity equipment)
    {
        return new EquipmentDto
        {
            Id = equipment.Id,
            Name = equipment.Name,
            SerialNumber = equipment.SerialNumber,
            Type = equipment.Type,
            Status = equipment.Status,
            UserId = equipment.UserId
        };
    }
}