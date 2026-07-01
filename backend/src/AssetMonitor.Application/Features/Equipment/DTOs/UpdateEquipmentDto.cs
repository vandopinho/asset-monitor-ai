namespace AssetMonitor.Application.Features.Equipment.DTOs;

public class UpdateEquipmentDto
{
    public string Name { get; set; } = string.Empty;

    public string SerialNumber { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
}