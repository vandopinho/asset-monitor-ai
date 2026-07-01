using AssetMonitor.Domain.Common;

namespace AssetMonitor.Domain.Entities;

public class Equipment : BaseEntity
{
    public string Name { get; private set; } = string.Empty;

    public string SerialNumber { get; private set; } = string.Empty;

    public string Type { get; private set; } = string.Empty;

    public string Status { get; private set; } = "Active";

    public Guid UserId { get; private set; }

    public User User { get; private set; } = null!;

    private Equipment() { }

    public Equipment(string name, string serialNumber, string type, Guid userId)
    {
        Name = name;
        SerialNumber = serialNumber;
        Type = type;
        UserId = userId;
        Status = "Active";
    }

    public void Update(string name, string type, string status)
    {
        Name = name;
        Type = type;
        Status = status;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Deactivate()
    {
        Status = "Inactive";
        UpdatedAt = DateTime.UtcNow;
    }
}