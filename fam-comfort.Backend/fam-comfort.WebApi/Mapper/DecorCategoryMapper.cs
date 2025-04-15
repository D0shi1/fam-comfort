using fam_comfort.Core.Models;
using fam_comfort.WebApi.Contract;

namespace fam_comfort.WebApi.Mapper;

public static class DecorCategoryMapper
{
    public static DecorCategoryDto ToDto(this DecorCategory category)
    {
        return new DecorCategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            PathToImage = category.PathToImage,
        };
    }
}