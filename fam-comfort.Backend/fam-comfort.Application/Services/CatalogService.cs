using fam_comfort.Application.Helpers;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class CatalogService
{
    private readonly ICatalogRepository _catalogRepository;

    public CatalogService(ICatalogRepository catalogRepository)
    {
        _catalogRepository = catalogRepository;
    }
    
    public async Task<List<Catalog>> GetAllAsync(QueryObject query)
    {
        return await _catalogRepository.GetAllAsync(query);
    }
    public async Task<Catalog?> GetByIdAsync(Guid id)
    {
        return await _catalogRepository.GetByIdAsync(id);
    }
    
    public async Task<Catalog?> GetByNameAsync(string name)
    {
        return await _catalogRepository.GetByNameAsync(name);
    }

    public async Task<Catalog?> UpdateAsync(Guid id, string name, string pathToImage)
    {
        return await _catalogRepository.UpdateAsync(id, name, pathToImage);
    }
    
    public async Task<Catalog?> DeleteAsync(Guid id)
    {
        return await _catalogRepository.DeleteAsync(id);
    }
    
    public async Task <Catalog> CreateAsync(string name, string pathToImage)
    {
        var facadeCategory = Catalog.Create(Guid.NewGuid(), name, pathToImage);
        return await _catalogRepository.CreateAsync(facadeCategory);
    }
}