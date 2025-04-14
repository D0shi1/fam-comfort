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
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var facades = await _facadeService.GetAllAsync();
        return Ok(facades.Select(f => f.ToDto()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] FacadeRequest request)
    {
        await _facadeService.CreateAsync(request.Name, request.ShortName, request.Length, request.Width, request.Height, request.Description, request.Colors, request.Materials, request.PathToImage, request.PathToImageSchema);
        return Created();
    }
}