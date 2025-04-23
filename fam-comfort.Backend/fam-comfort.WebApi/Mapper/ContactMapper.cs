using fam_comfort.Application.Contract.Dto;
using fam_comfort.Core.Models;

namespace fam_comfort.WebApi.Mapper;

public static class ContactMapper
{
    public static ContactDto ToDto(this Contact contact)
    {
        return new ContactDto
        {
            Id = contact.Id,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            Email = contact.Email,
            Rank = contact.Rank,
            Languages = contact.Languages,
            Description = contact.Description,
        };
    }
}