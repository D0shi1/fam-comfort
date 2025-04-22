using fam_comfort.Application.Contract.Dto;
using fam_comfort.Application.Contract.ViewModels;
using fam_comfort.Core.Models;

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