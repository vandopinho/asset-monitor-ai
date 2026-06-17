using AssetMonitor.Domain.Common;

namespace AssetMonitor.Domain.Entities;

public class User : BaseEntity
{
    public string Name { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public string PasswordHash { get; private set; } = string.Empty;

    public string Role { get; private set; } = "Operator";

    public bool Active { get; private set; } = true;

    private User()
    {
    }

    public User(
        string name,
        string email,
        string passwordHash,
        string role = "Operator")
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
        Active = true;
    }

    public void Deactivate()
    {
        Active = false;
    }
    public void Activate()
    {
        Active = true;
    }

    public void Delete()
    {
        IsDeleted = true;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Update(
        string name,
        string email,
        string role)
    {
        Name = name;
        Email = email;
        Role = role;
        UpdatedAt = DateTime.UtcNow;
    }
}