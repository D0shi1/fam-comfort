using fam_comfort.Application.Helpers;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/catalog")]
[ApiController]
public class CatalogController : ControllerBase
{
    private readonly CatalogService _catalogService;

    public CatalogController(CatalogService catalogService)
    {
        _catalogService = catalogService;
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var catalog = await _catalogService.GetByIdAsync(id);
        
        if(catalog == null) return NotFound();
        
        return Ok(catalog.ToDto());
    }
    
    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var catalog = await _catalogService.GetByNameAsync(name);
        
        if(catalog == null) return NotFound();
        
        return Ok(catalog.ToDto());
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery]QueryObject query)
    {
        var catalog = await _catalogService.GetAllAsync(query);
        return Ok(catalog.Select(s => s.ToDto()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CatalogRequest request)
    {
        await _catalogService.CreateAsync(request.Name, request.PathToImage);
        return Created();
    }
    
    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] CatalogRequest request, Guid id)
    {
        var result = await _catalogService.UpdateAsync(id, request.Name, request.PathToImage);
        if(result == null) return NotFound();
        
        return Ok();
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _catalogService.DeleteAsync(id);
        if(result == null) return NotFound();

        return Ok();
    }
}