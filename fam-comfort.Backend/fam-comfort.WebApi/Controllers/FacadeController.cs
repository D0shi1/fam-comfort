using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/facade")]
[ApiController]
public class FacadeController : ControllerBase
{
    private readonly FacadeService _facadeService;

    public FacadeController(FacadeService facadeService)
    {
        _facadeService = facadeService;
    }

    [HttpGet("{facadeCategoryId:guid}")]
    public async Task<IActionResult> GetAll(Guid facadeCategoryId)
    {
        var facades = await _facadeService.GetAllAsync(facadeCategoryId);
        if (facades is null) return NotFound();

        return Ok(facades.Select(f => f.ToDto()));
    }

    [HttpGet("get-by-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var facadeCategory = await _facadeService.GetByIdAsync(id);

        if (facadeCategory == null) return NotFound();

        return Ok(facadeCategory.ToDto());
    }
    
    [HttpGet("get-by-color/{id:guid}")]
    public async Task<IActionResult> GetByColor(Guid id)
    {
        var facadeCategory = await _facadeService.GetByColorAsync(id);

        if (facadeCategory == null) return NotFound();

        return Ok(facadeCategory.ToDto());
    }
    
    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var facadeCategory = await _facadeService.GetByNameAsync(name);

        if (facadeCategory == null) return NotFound();

        return Ok(facadeCategory.ToDto());
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] FacadeRequest request)
    {
        var facade = await _facadeService.CreateAsync(request.FacadeCategoryId, request.Name, request.ShortName,
            request.Length, request.Width, request.Height, request.Description,
            request.Materials, request.PathToImageSchema);

        if (facade is null) return BadRequest();

        return Created();
    }

    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] FacadeRequest request, Guid id)
    {
        var result = await _facadeService.UpdateAsync(id, request.Name, request.ShortName, request.Length,
            request.Width, request.Height, request.Description, request.Materials, request.PathToImageSchema);
        if (result == null) return NotFound();

        return Ok();
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _facadeService.DeleteAsync(id);
        if (result == null) return NotFound();

        return Ok();
    }
}