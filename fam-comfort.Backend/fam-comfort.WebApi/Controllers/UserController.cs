using System.Net;
using fam_comfort.Application.Services;
using fam_comfort.Application.ViewModels;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/User")]
[ApiController]
public class UserController(UserService userService) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRequest request)
    {
        try
        {
            var user = await userService.Register(request.Username, request.Password);
            return Ok(user.ToDto());
        }
        catch (Exception ex)
        {
            return StatusCode(500, "User is already registered");
        }
    }
    
    [HttpPost("login")]
    public async Task<IActionResult> Login(UserRequest request)
    {
        try
        {
            var token = await userService.Login(request.Username, request.Password);
            
            HttpContext.Response.Cookies.Append("token", token);
        
            return Ok();
        }
        catch (UnauthorizedAccessException ex)
        {
            return StatusCode(500, "Invalid username or password");
        }
    }
}