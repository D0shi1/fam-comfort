using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class FacadeCategoryService
{
    private readonly IFacadeCategoryRepository _facadeCategoryRepository;

    public FacadeCategoryService(IFacadeCategoryRepository facadeCategoryRepository)
    {
        _facadeCategoryRepository = facadeCategoryRepository;
    }
    public async Task<List<FacadeCategory>> GetAllAsync()
    {
        return await _facadeCategoryRepository.GetAllAsync();
    }

    public async Task <FacadeCategory> CreateAsync(string name, string pathToImage)
    {
        var facadeCategory = FacadeCategory.Create(Guid.NewGuid(), name, pathToImage);
        return await _facadeCategoryRepository.CreateAsync(facadeCategory);
    }
}