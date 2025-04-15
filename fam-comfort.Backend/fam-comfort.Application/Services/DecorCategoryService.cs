using fam_comfort.Application.Helpers;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class DecorCategoryService(IDecorCategoryRepository decorCategoryRepository)
{
    public async Task<List<DecorCategory>> GetAllAsync(QueryObject query)
    {
        return await decorCategoryRepository.GetAllAsync(query);
    }
    public async Task<DecorCategory?> GetByIdAsync(Guid id)
    {
        return await decorCategoryRepository.GetByIdAsync(id);
    }
    
    public async Task<DecorCategory?> GetByNameAsync(string name)
    {
        return await decorCategoryRepository.GetByNameAsync(name);
    }

    public async Task<DecorCategory?> UpdateAsync(Guid id, string name, string pathToImage)
    {
        return await decorCategoryRepository.UpdateAsync(id, name, pathToImage);
    }
    
    public async Task<DecorCategory?> DeleteAsync(Guid id)
    {
        return await decorCategoryRepository.DeleteAsync(id);
    }
    
    public async Task <DecorCategory> CreateAsync(string name, string pathToImage)
    {
        var decorCategory = DecorCategory.Create(Guid.NewGuid(), name, pathToImage);
        return await decorCategoryRepository.CreateAsync(decorCategory);
    }
}