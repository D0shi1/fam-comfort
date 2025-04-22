using fam_comfort.Application.Contract.ViewModels;
using fam_comfort.Application.Services;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/colors")]
[ApiController]
public class ColorController(ColorService colorService) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetColors(Guid id)
    {
        var colors = await colorService.GetAllAsync(id);
        if (colors is null) return NotFound();
        return Ok(colors);
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ColorRequest request)
    {
        var color = await colorService.CreateAsync(request.ProductId, request.Name, request.PathToImage);
        if (color is null) return NotFound();

        return Created();
    }

    [HttpGet("get-by-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var facadeCategory = await colorService.GetByIdAsync(id);

        if (facadeCategory == null) return NotFound();

        return Ok(facadeCategory.ToDto());
    }

    [Authorize]
    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] ColorRequest request, Guid id)
    {
        var result = await colorService.UpdateAsync(id, request.Name, request.PathToImage);
        if (result == null) return NotFound();

        return Ok();
    }

    [Authorize]
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await colorService.DeleteAsync(id);
        if (result == null) return NotFound();

        return Ok();
    }
}