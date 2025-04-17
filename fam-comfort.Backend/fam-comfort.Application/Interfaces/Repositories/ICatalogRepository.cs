using fam_comfort.Application.Helpers;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface ICatalogRepository
{
    Task<List<Catalog>> GetAllAsync(QueryObject query);
    Task<Catalog?> GetByIdAsync(Guid catalogId);
    Task<Catalog?> GetByNameAsync(string name);
    Task<Catalog> CreateAsync(Catalog catalog);
    Task<Catalog?> UpdateAsync(Guid catalogId, string name, string pathToImage);
    Task<Catalog?> DeleteAsync(Guid catalogId);
    Task<bool> ExistsAsync(Guid catalogId);
}