using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IDecoreRepository
{
    Task<List<Decor>> GetAllAsync(Guid facadeCategoryId);
    Task<Decor> CreateAsync(Facade facade);
    Task<Decor?> GetByIdAsync(Guid facadeId);
    Task<Decor?> GetByColorAsync(Guid colorId);
    Task<Decor?> GetByNameAsync(string name);
    Task<Decor?> UpdateAsync(Guid facadeId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema);
    Task<Decor?> DeleteAsync(Guid facadeId);
    Task<bool> FacadeExistsAsync(Guid id);
}