using fam_comfort.Application.Helpers;
using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;
[Route("api/v1/facade-categories")]
[ApiController]
public class FacadeCategoryController : ControllerBase
{
    private readonly FacadeCategoryService _service;

    public FacadeCategoryController(FacadeCategoryService service)
    {
        _service = service;
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var facadeCategory = await _service.GetByIdAsync(id);
        
        if(facadeCategory == null) return NotFound();
        
        return Ok(facadeCategory.ToDto());
    }
    
    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var facadeCategory = await _service.GetByNameAsync(name);
        
        if(facadeCategory == null) return NotFound();
        
        return Ok(facadeCategory.ToDto());
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
    {
        var facadeCategory = await _service.GetAllAsync(query);
        return Ok(facadeCategory.Select(f => f.ToDto()));
    }
    
    [Authorize]
    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] FacadeCategoryRequest request)
    {
        await _service.CreateAsync(request.Name, request.PathToImage);
        return Created();
    }

    [Authorize]
    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] FacadeCategoryRequest request, Guid id)
    {
        var result = await _service.UpdateAsync(id, request.Name, request.PathToImage);
        if(result == null) return NotFound();
        
        return Ok();
    }

    [Authorize]
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.DeleteAsync(id);
        if(result == null) return NotFound();

        return Ok();
    }
}