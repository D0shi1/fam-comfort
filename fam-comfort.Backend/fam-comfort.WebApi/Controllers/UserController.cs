using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Contract;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/User")]
[ApiController]
public class UserController(UserService userService) : ControllerBase
{
    private readonly UserService _userService = userService;

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRequest request, UserService userService)
    {
        var user = await userService.Register(request.Username, request.Password);

        return Ok(user.ToDto());
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserRequest request, UserService userService)
    {
        var token = await userService.Login(request.Username, request.Password);
        
        return Ok(token);
    }
}