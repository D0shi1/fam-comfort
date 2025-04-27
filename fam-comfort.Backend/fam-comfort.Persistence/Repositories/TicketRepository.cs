using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly FamComfortDbContext _context;

    public TicketRepository(FamComfortDbContext context)
    {
        _context = context;
    }

    public async Task<List<Ticket>> GetAllAsync()
    {
        return await _context.Tickets.ToListAsync();
    }

    public async Task<Ticket> CreateAsync(Ticket ticket)
    {
        await _context.Tickets.AddAsync(ticket);
        await _context.SaveChangesAsync();

        return ticket;
    }

    public async Task<Ticket?> DeleteAsync(Guid ticketId)
    {
        var ticket = await _context.Tickets.FirstOrDefaultAsync(c => c.Id == ticketId);
        if(ticket == null) return null;
        
        _context.Tickets.Remove(ticket);
        await _context.SaveChangesAsync();

        return ticket;
    }
}