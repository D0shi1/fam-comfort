using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class TagService(ITagRepository tagRepository, IProductRepository productRepository)
{
    public async Task<List<Tag>?> GetAllAsync()
    {
        return await tagRepository.GetAllAsync();
    }

    public async Task<Tag?> GetByIdAsync(Guid id)
    {
        return await tagRepository.GetByIdAsync(id);
    }

    public async Task<Tag?> GetByNameAsync(string name)
    {
        return await tagRepository.GetByNameAsync(name);
    }

    public async Task<Tag?> UpdateAsync(Guid id, string name)
    {
        return await tagRepository.UpdateAsync(id, name);
    }

    public async Task<Tag?> DeleteAsync(Guid id)
    {
        return await tagRepository.DeleteAsync(id);
    }

    public async Task<Tag?> CreateAsync(string name)
    {
        var tag = Tag.Create(Guid.NewGuid(), name);
        return await tagRepository.CreateAsync(tag);
    }
}