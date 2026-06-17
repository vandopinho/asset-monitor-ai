namespace AssetMonitor.Application.Features.Users.DTOs;

public class CreateUserDto
{
    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Role { get; set; } = "Operator";
}