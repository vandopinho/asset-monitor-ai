using AssetMonitor.Application.Features.Authentication.DTOs;
using AssetMonitor.Application.Features.Authentication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace AssetMonitor.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _service;

    public AuthController(IAuthService service)
    {
        _service = service;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(
        LoginRequestDto request)
    {
        var response = await _service.LoginAsync(request);

        if (response is null)
            return Unauthorized(new
            {
                message = "Invalid credentials."
            });

        return Ok(response);
    }
    [HttpGet("me")]
    [Authorize]
    public async Task<IActionResult> Me()
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value
                         ?? User.FindFirst("sub")?.Value;

        if (userIdClaim is null)
            return Unauthorized();

        var userId = Guid.Parse(userIdClaim);

        var user = await _service.GetCurrentUserAsync(userId);

        if (user is null)
            return NotFound();

        return Ok(user);
    }
}