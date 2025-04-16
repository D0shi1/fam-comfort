using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IDecorRepository
{
    Task<List<Decor>> GetAllAsync(Guid decorCategoryId);
    Task<Decor> CreateAsync(Decor decor);
    Task<Decor?> GetByIdAsync(Guid decorId);
    Task<Decor?> GetByNameAsync(string name);
    Task<Decor?> UpdateAsync(Guid decorId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema);
    Task<Decor?> DeleteAsync(Guid decorId);
    Task<bool> FacadeExistsAsync(Guid id);
}