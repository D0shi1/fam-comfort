using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/facade")]
[ApiController]
public class FacadeController(FacadeService facadeService) : ControllerBase
{
    [HttpGet("{facadeCategoryId:guid}")]
    public async Task<IActionResult> GetAll(Guid facadeCategoryId)
    {
        var facades = await facadeService.GetAllAsync(facadeCategoryId);
        if (facades is null) return NotFound();

        return Ok(facades.Select(f => f.ToDto()));
    }

    [HttpGet("get-by-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var facadeCategory = await facadeService.GetByIdAsync(id);

        if (facadeCategory == null) return NotFound();

        return Ok(facadeCategory.ToDto());
    }
    
    [HttpGet("get-by-color/{id:guid}")]
    public async Task<IActionResult> GetByColor(Guid id)
    {
        var facadeCategory = await facadeService.GetByColorAsync(id);

        if (facadeCategory == null) return NotFound();

        return Ok(facadeCategory.ToDto());
    }
    
    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var facadeCategory = await facadeService.GetByNameAsync(name);

        if (facadeCategory == null) return NotFound();

        return Ok(facadeCategory.ToDto());
    }

    [Authorize]
    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] FacadeRequest request)
    {
        var facade = await facadeService.CreateAsync(request.FacadeCategoryId, request.Name, request.ShortName,
            request.Length, request.Width, request.Height, request.Description,
            request.Materials, request.PathToImageSchema);

        if (facade is null) return BadRequest();

        return Created();
    }

    [Authorize]
    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] FacadeRequest request, Guid id)
    {
        var result = await facadeService.UpdateAsync(id, request.Name, request.ShortName, request.Length,
            request.Width, request.Height, request.Description, request.Materials, request.PathToImageSchema);
        if (result == null) return NotFound();

        return Ok();
    }

    [Authorize]
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await facadeService.DeleteAsync(id);
        if (result == null) return NotFound();

        return Ok();
    }
}