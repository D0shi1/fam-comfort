using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Contract;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;
[Route("api/v1/colors")]
[ApiController]
public class ColorController : ControllerBase
{
    private readonly ColorService _colorService;

    public ColorController(ColorService colorService)
    {
        _colorService = colorService;
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetColors(Guid id)
    {
        var colors = await _colorService.GetAllAsync(id);
        if (colors is null) return NotFound();
        return Ok(colors);
    }
    
    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ColorRequest request)
    {
       var color = await _colorService.CreateAsync(request.FacadeId, request.Name, request.PathToImage);
       if(color is null) return NotFound();
       
       return Created();
    }
    
    [HttpGet("get-by-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var facadeCategory = await _colorService.GetByIdAsync(id);

        if (facadeCategory == null) return NotFound();

        return Ok(facadeCategory.ToDto());
    }

    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] ColorRequest request, Guid id)
    {
        var result = await _colorService.UpdateAsync(id, request.Name, request.PathToImage);
        if (result == null) return NotFound();

        return Ok();
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _colorService.DeleteAsync(id);
        if (result == null) return NotFound();

        return Ok();
    }
}