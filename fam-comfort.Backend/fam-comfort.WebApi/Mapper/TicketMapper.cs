using fam_comfort.Application.Contract.Dto;
using fam_comfort.Core.Models;

namespace fam_comfort.WebApi.Mapper;

public static class TicketMapper
{
    public static TicketDto ToDto(this Ticket ticket)
    {
        return new TicketDto
        {
            Title = ticket.Title,
            PhoneNumber = ticket.PhoneNumber,
            Email = ticket.Email
        };
    }
}