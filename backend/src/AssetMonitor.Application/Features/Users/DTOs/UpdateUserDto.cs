namespace AssetMonitor.Application.Features.Users.DTOs;

public class UpdateUserDto
{
    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Role { get; set; } = "Operator";

    public bool Active { get; set; }
}