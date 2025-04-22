using fam_comfort.Application.Contract.Dto;
using fam_comfort.Core.Models;

namespace fam_comfort.WebApi.Mapper;

public static class CatalogMapper
{
    public static CatalogDto ToDto(this Catalog catalog)
    {
        return new CatalogDto
        {
            Id = catalog.Id,
            Name = catalog.Name,
            PathToImage = catalog.PathToImage,
            Categories = catalog.Categories.Select(s => s.ToDto()).ToList()
        };
    }
}