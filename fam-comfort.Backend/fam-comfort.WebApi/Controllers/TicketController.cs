using fam_comfort.Application.Contract.ViewModels;
using fam_comfort.Application.Services;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[Route("api/v1/ticket")]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly TicketService _ticketService;

    public TicketController(TicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var tickets = await _ticketService.GetAllTicketsAsync();
        return Ok(tickets.Select(t => t.ToDto()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] TicketRequest request)
    {
        await _ticketService.CreateAsync(request.Title, request.PhoneNumber, request.Email);
        return Created();
    }

    [HttpPut("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _ticketService.DeleteAsync(id);
        return Ok();
    }
}