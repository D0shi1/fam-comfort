using fam_comfort.Application.Helpers;
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
    public async Task<List<FacadeCategory>> GetAllAsync(QueryObject query)
    {
        return await _facadeCategoryRepository.GetAllAsync(query);
    }
    public async Task<FacadeCategory?> GetByIdAsync(Guid id)
    {
        return await _facadeCategoryRepository.GetByIdAsync(id);
    }
    
    public async Task<FacadeCategory?> GetByNameAsync(string name)
    {
        return await _facadeCategoryRepository.GetByNameAsync(name);
    }

    public async Task<FacadeCategory?> UpdateAsync(Guid id, string name, string pathToImage)
    {
        return await _facadeCategoryRepository.UpdateAsync(id, name, pathToImage);
    }
    
    public async Task<FacadeCategory?> DeleteAsync(Guid id)
    {
        return await _facadeCategoryRepository.DeleteAsync(id);
    }
    
    public async Task <FacadeCategory> CreateAsync(string name, string pathToImage)
    {
        var facadeCategory = FacadeCategory.Create(Guid.NewGuid(), name, pathToImage);
        return await _facadeCategoryRepository.CreateAsync(facadeCategory);
    }
}