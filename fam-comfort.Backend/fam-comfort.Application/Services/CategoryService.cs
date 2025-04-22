using fam_comfort.Application.Helpers;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class CategoryService
{
    private readonly ICategoryRepository _repository;

    public CategoryService(ICategoryRepository repository)
    {
        _repository = repository;
    }
    public async Task<List<Category>> GetAllAsync(Guid catalogId)
    {
        return await _repository.GetAllAsync(catalogId);
    }

    public async Task<Category?> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<List<Category>?> GetByNameAsync(string name)
    {
        return await _repository.GetByNameAsync(name);
    }

    public async Task<Category?> UpdateAsync(Guid id, string name, string pathToImage)
    {
        return await _repository.UpdateAsync(id, name, pathToImage);
    }

    public async Task<Category?> DeleteAsync(Guid id)
    {
        return await _repository.DeleteAsync(id);
    }

    public async Task<Category> CreateAsync(Guid catalogId,string name, string pathToImage)
    {
        var category = Category.Create(Guid.NewGuid(), name, pathToImage, catalogId);
        return await _repository.CreateAsync(category);
    }
}