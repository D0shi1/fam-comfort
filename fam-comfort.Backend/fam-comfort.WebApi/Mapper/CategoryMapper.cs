using fam_comfort.Application.Contract.Dto;
using fam_comfort.Core.Models;

namespace fam_comfort.WebApi.Mapper;

public static class CategoryMapper
{
    public static CategoryDto ToDto(this Category category)
    {
        return new CategoryDto
        {
            CategoryId = category.Id,
            Name = category.Name,
            PathToImage = category.PathToImage,
        };
    }
}