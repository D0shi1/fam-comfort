using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IFacadeCategoryRepository
{
    Task<List<FacadeCategory>> GetAllAsync();
    Task<FacadeCategory> CreateAsync(FacadeCategory facadeCategory);
}