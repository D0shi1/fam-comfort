using fam_comfort.Application.Helpers;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IDecorCategoryRepository
{
    Task<List<DecorCategory>> GetAllAsync(QueryObject query);
    Task<DecorCategory?> GetByIdAsync(Guid id);
    Task<DecorCategory?> GetByNameAsync(string name);
    Task<DecorCategory> CreateAsync(DecorCategory decorCategory);
    Task<DecorCategory?> UpdateAsync(Guid decorCategoryId, string name, string pathToImage);
    Task<DecorCategory?> DeleteAsync(Guid decorCategoryId);
    Task<bool> DecorCategoryExistsAsync(Guid id);
}