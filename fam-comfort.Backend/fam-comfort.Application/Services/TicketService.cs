using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class TicketService
{
    private readonly ITicketRepository _ticketRepository;

    public TicketService(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<List<Ticket>> GetAllTicketsAsync()
    {
        return await _ticketRepository.GetAllAsync();
    }

    public async Task<Ticket> CreateAsync(string title, string phoneNumber, string email)
    {
        var ticket = Ticket.Create(Guid.NewGuid(), title, phoneNumber, email);
        return await _ticketRepository.CreateAsync(ticket);
    }

    public async Task<Ticket?> DeleteAsync(Guid id)
    {
        return await _ticketRepository.DeleteAsync(id);
    }
}