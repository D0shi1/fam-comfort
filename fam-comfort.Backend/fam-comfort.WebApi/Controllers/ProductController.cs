using fam_comfort.Application.Contract.ViewModels;
using fam_comfort.Application.Services;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/products")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ProductService _productService;
    private readonly ColorService _colorService;

    public ProductController(ProductService productService, ColorService colorService)
    {
        _productService = productService;
        _colorService = colorService;
    }

    [HttpGet("{categoryId:guid}")]
    public async Task<IActionResult> GetAll(Guid categoryId)
    {
        var products = await _productService.GetAllAsync(categoryId);
        if (products is null) return NotFound();

        return Ok(products.Select(f => f.ToDto()));
    }

    [HttpGet("get-by-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var product = await _productService.GetByIdAsync(id);

        if (product == null) return NotFound();

        return Ok(product.ToDto());
    }

    [HttpGet("get-by-color/{colorId:guid}")]
    public async Task<IActionResult> GetByColor(Guid id)
    {
        var product = await _productService.GetByColorAsync(id);

        if (product == null) return NotFound();

        return Ok(product.ToDto());
    }

    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var product = await _productService.GetByNameAsync(name);

        if (product == null) return NotFound();

        return Ok(product.Select(p => p.ToDto()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] ProductRequest request)
    {
        var product = await _productService.CreateAsync(request.CategoryId, request.Name,
            request.ShortName,
            request.Length, request.Width, request.Height, request.Description,
            request.Materials, request.PathToImageSchema);
        if (product is null) return BadRequest();

        foreach (var createColorRequest in request.Colors)
        {
            await _colorService.CreateAsync(product.Id, createColorRequest.Name, createColorRequest.PathToImage);
        }

        return Created();
    }

    [Authorize]
    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update([FromBody] ProductRequest request, Guid id)
    {
        var result = await _productService.UpdateAsync(id, request.Name, request.ShortName, request.Length,
            request.Width, request.Height, request.Description, request.Materials, request.PathToImageSchema);
        if (result == null) return NotFound();

        return Ok();
    }

    [Authorize]
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _productService.DeleteAsync(id);
        if (result == null) return NotFound();

        return Ok();
    }
}