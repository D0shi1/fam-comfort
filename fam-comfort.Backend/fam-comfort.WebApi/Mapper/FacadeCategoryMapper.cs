using fam_comfort.Core.Models;
using fam_comfort.WebApi.Contract;

namespace fam_comfort.WebApi.Mapper;

public static class FacadeCategoryMapper
{
    public static FacadeCategoryDto ToDto(this FacadeCategory category)
    {
        return new FacadeCategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            PathToImage = category.PathToImage,
        };
    }
}