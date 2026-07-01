namespace AssetMonitor.Application.Features.Equipment.DTOs;

public class CreateEquipmentDto
{
    public string Name { get; set; } = string.Empty;

    public string SerialNumber { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public Guid UserId { get; set; }
}