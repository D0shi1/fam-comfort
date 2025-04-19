using fam_comfort.Core.Models;
using fam_comfort.WebApi.Contract;

namespace fam_comfort.WebApi.Mapper;

public static class TagMapper
{
    public static TagDto ToDto(this Tag tag)
    {
        return new TagDto
        {
            Id = tag.Id,
            Name = tag.Name,
        };
    }
}