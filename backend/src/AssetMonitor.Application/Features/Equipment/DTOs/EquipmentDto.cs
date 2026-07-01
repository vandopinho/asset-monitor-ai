namespace AssetMonitor.Application.Features.Equipment.DTOs;

public class EquipmentDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string SerialNumber { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public Guid UserId { get; set; }
}