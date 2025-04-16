using fam_comfort.Core.Models;
using fam_comfort.WebApi.Contract;

namespace fam_comfort.WebApi.Mapper;

public static class DecorMapper
{
    public static DecorDto ToDto(this Decor decor)
    {
        return new DecorDto
        {
            Id = decor.Id,
            Description = decor.Description,
            Height = decor.Height,
            Width = decor.Width,
            Length = decor.Length,
            Materials = decor.Materials,
            Name = decor.Name,
            ShortName = decor.ShortName,
            PathToImageSchema = decor.PathToImageSchema,
        };
    }
}