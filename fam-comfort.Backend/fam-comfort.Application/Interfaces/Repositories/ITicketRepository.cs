using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface ITicketRepository
{
    Task<List<Ticket>> GetAllAsync();
    Task<Ticket> CreateAsync(Ticket ticket);
    Task<Ticket?> DeleteAsync(Guid ticketId);
}