using AssetMonitor.Application.Common.Responses;
using AssetMonitor.Application.Features.Equipment.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AssetMonitor.Application.Features.Equipment.DTOs;
namespace AssetMonitor.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EquipmentController : ControllerBase
{
    private readonly IEquipmentService _service;

    public EquipmentController(IEquipmentService service)
    {
        _service = service;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(CreateEquipmentDto dto)
    {
        var equipment = await _service.CreateAsync(dto);

        return CreatedAtAction(
            nameof(GetById),
            new { id = equipment.Id },
            ApiResponse<EquipmentDto>.Ok(equipment));
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetAll()
    {
        var equipments = await _service.GetAllAsync();

        return Ok(ApiResponse<List<EquipmentDto>>.Ok(equipments));
    }

    [HttpGet("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> GetById(Guid id)
    {
        var equipment = await _service.GetByIdAsync(id);

        if (equipment is null)
            return NotFound();

        return Ok(ApiResponse<EquipmentDto>.Ok(equipment));
    }

    [HttpPut("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Update(Guid id, UpdateEquipmentDto dto)
    {
        var equipment = await _service.UpdateAsync(id, dto);

        if (equipment is null)
            return NotFound();

        return Ok(ApiResponse<EquipmentDto>.Ok(equipment));
    }

    [HttpDelete("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeleteAsync(id);

        return NoContent();
    }
}