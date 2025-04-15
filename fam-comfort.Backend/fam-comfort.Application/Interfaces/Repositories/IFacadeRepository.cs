using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IFacadeRepository
{
    Task<List<Facade>> GetAllAsync(Guid facadeCategoryId);
    Task<Facade> CreateAsync(Facade facade);
    Task<Facade?> GetByIdAsync(Guid facadeId);
    Task<Facade?> GetByColorAsync(Guid colorId);
    Task<Facade?> GetByNameAsync(string name);
    Task<Facade?> UpdateAsync(Guid facadeId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema);
    Task<Facade?> DeleteAsync(Guid facadeId);
    Task<bool> FacadeExistsAsync(Guid id);
}