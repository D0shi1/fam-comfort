using fam_comfort.Core.Models;
using fam_comfort.WebApi.Contract;

namespace fam_comfort.WebApi.Mapper;

public static class ColorMapper
{
    public static ColorDto ToDto(this Color color)
    {
        return new ColorDto
        {
            Id = color.Id,
            Name = color.Name,
            PathToImage = color.PathToImage
        };
    }
}