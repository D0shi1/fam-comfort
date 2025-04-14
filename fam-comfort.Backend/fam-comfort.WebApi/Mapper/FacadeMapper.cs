using fam_comfort.Core.Models;
using fam_comfort.WebApi.Contract;

namespace fam_comfort.WebApi.Mapper;

public static class FacadeMapper
{
    public static FacadeDto ToDto(this Facade facade)
    {
        return new FacadeDto
        {
            Id = facade.Id,
            Colors = facade.Colors,
            Description = facade.Description,
            Height = facade.Height,
            Width = facade.Width,
            Length = facade.Length,
            Materials = facade.Materials,
            Name = facade.Name,
            ShortName = facade.ShortName,
            PathToImage = facade.PathToImage,
            PathToImageSchema = facade.PathToImageSchema,
        };
    }

}