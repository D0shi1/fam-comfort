using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.Core.Models;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/tag")]
[ApiController]
public class TagController(TagService tagService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var tags = await tagService.GetAllAsync();
        
        if(tags is null) return NotFound();
        
        return Ok();
    }

    [HttpGet("get-by-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var tag = await tagService.GetByIdAsync(id);
        
        if (tag is null) return NotFound();
        
        return Ok(tag.ToDto());
    }

    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var tag = await tagService.GetByNameAsync(name);
        
        if (tag is null) return NotFound();
        
        return Ok(tag.ToDto());
    }

    [Authorize]
    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] TagRequest request)
    {
        var tag = await tagService.CreateAsync(request.Name);
        
        if(tag is null)
            return NotFound();
        
        return Ok(tag.ToDto());
    }

    [Authorize]
    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] TagRequest request)
    {
        var tag = await tagService.UpdateAsync(id, request.Name);
        
        if(tag is null)
            return NotFound();
        
        return Ok(tag.ToDto());
    }

    [Authorize]
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var tag = await tagService.DeleteAsync(id);
        
        if(tag is null)
            return NotFound();
        
        return Ok(tag.ToDto());
    }
}