using fam_comfort.Application.Helpers;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IFacadeCategoryRepository
{
    Task<List<FacadeCategory>> GetAllAsync(QueryObject query);
    Task<FacadeCategory?> GetByIdAsync(Guid id);
    Task<FacadeCategory?> GetByNameAsync(string name);
    Task<FacadeCategory> CreateAsync(FacadeCategory facadeCategory);
    Task<FacadeCategory?> UpdateAsync(Guid facadeCategoryId, string name, string pathToImage);
    Task<FacadeCategory?> DeleteAsync(Guid facadeCategoryId);
    Task<bool> FacadeCategoryExistsAsync(Guid id);
}