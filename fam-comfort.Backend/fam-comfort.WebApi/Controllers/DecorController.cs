using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/decor")]
[ApiController]
public class DecorController(DecorService decorService) : ControllerBase
{
    [HttpGet("{decorCategoryId:guid}")]
    public async Task<IActionResult> GetAll(Guid decorCategoryId)
    {
        var decors = await decorService.GetAllAsync(decorCategoryId);
        if (decors is null) return NotFound();

        return Ok(decors.Select(f => f.ToDto()));
    }

    [HttpGet("get-by-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var decorCategory = await decorService.GetByIdAsync(id);

        if (decorCategory == null) return NotFound();

        return Ok(decorCategory.ToDto());
    }
    
    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var decorCategory = await decorService.GetByNameAsync(name);

        if (decorCategory == null) return NotFound();

        return Ok(decorCategory.ToDto());
    }

    [Authorize]
    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] DecorRequest request)
    {
        var decor = await decorService.CreateAsync(request.DecorCategoryId, request.Name, request.ShortName,
            request.Length, request.Width, request.Height, request.Description,
            request.Materials, request.PathToImageSchema);

        if (decor is null) return BadRequest();

        return Created();
    }

    [Authorize]
    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] DecorRequest request, Guid id)
    {
        var result = await decorService.UpdateAsync(id, request.Name, request.ShortName, request.Length,
            request.Width, request.Height, request.Description, request.Materials, request.PathToImageSchema);
        if (result == null) return NotFound();

        return Ok();
    }

    [Authorize]
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await decorService.DeleteAsync(id);
        if (result == null) return NotFound();

        return Ok();
    }
}