using fam_comfort.Application.Contract.ViewModels;
using fam_comfort.Application.Services;
using fam_comfort.WebApi.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace fam_comfort.WebApi.Controllers;

[ApiController]
[Route("/api/v1/contacts")]
public class ContactController(ContactService contactService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var contacts = await contactService.GetAllAsync();
        
        if(contacts == null) return BadRequest();
        
        return Ok(contacts.Select(c => c.ToDto()));
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var contact = await contactService.GetByIdAsync(id);
        
        if (contact == null) return BadRequest();
        
        return Ok(contact.ToDto());
    }

    [HttpGet("{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var contact = await contactService.GetByNameAsync(name);
        
        if (contact == null) return BadRequest();
        
        return Ok(contact.ToDto());
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] ContactRequest request)
    {
        var contact = await contactService.CreateAsync(request.FirstName, request.LastName, request.Email,
            request.PhoneNumber, request.Rank, request.Languages, request.Description);
        
        if (contact == null) return BadRequest();
        
        return Ok(contact.ToDto());
    }

    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] ContactRequest request)
    {
        var contact = await contactService.UpdateAsync(id, request.FirstName, request.LastName, request.Email,
            request.PhoneNumber, request.Rank, request.Languages, request.Description);
        
        if (contact == null) return BadRequest();
        
        return Ok(contact.ToDto());
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var contact = await contactService.DeleteAsync(id);
        
        if (contact == null) return BadRequest();
        
        return Ok(contact.ToDto());
    }
}