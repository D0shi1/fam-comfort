using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.Core.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var facadeCategory = await _service.GetAllAsync();
        return Ok(facadeCategory);
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] FacadeCategoryRequest request)
    {
        await _service.CreateAsync(request.Name, request.PathToImage);
        return Created();
    }
}