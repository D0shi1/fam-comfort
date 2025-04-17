using fam_comfort.Application.Helpers;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllAsync(Guid catalogId);
    Task<Category?> GetByIdAsync(Guid categoryId);
    Task<Category?> GetByNameAsync(string name);
    Task<Category> CreateAsync(Category catalog);
    Task<Category?> UpdateAsync(Guid categoryId, string name, string pathToImage);
    Task<Category?> DeleteAsync(Guid categoryId);
    Task<bool> ExistsAsync(Guid categoryd);
}