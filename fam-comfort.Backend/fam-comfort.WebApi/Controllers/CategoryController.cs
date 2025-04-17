using fam_comfort.Application.Helpers;
using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/categories")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly CategoryService _categoryService;

    public CategoryController(CategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    
    [HttpGet("get-by-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var category = await _categoryService.GetByIdAsync(id);
        
        if(category == null) return NotFound();
        
        return Ok(category.ToDto());
    }
    
    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var category = await _categoryService.GetByNameAsync(name);
        
        if(category == null) return NotFound();
        
        return Ok(category.ToDto());
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAll(Guid id)
    {
        var category = await _categoryService.GetAllAsync(id);
        return Ok(category.Select(s => s.ToDto()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CategoryRequest request)
    {
        await _categoryService.CreateAsync(request.CatalogId, request.Name, request.PathToImage);
        return Created();
    }
    
    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] CatalogRequest request, Guid id)
    {
        var result = await _categoryService.UpdateAsync(id, request.Name, request.PathToImage);
        if(result == null) return NotFound();
        
        return Ok();
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _categoryService.DeleteAsync(id);
        if(result == null) return NotFound();

        return Ok();
    }
}