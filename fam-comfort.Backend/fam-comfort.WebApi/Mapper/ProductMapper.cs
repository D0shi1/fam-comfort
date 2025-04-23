using fam_comfort.Application.Contract.Dto;
using fam_comfort.Core.Models;

namespace fam_comfort.WebApi.Mapper;

public static class ProductMapper
{
    public static ProductDto ToDto(this Product product)
    {
        return new ProductDto
        {
            Id = product.Id,
            Colors = product.Colors.Select(c => c.ToDto()).ToList(),
            Description = product.Description,
            Height = product.Height,
            Width = product.Width,
            Length = product.Length,
            Materials = product.Materials,
            Name = product.Name,
            ShortName = product.ShortName,
            PathToImageSchema = product.PathToImageSchema,
            TagId = product.TagId
        };
    }
}