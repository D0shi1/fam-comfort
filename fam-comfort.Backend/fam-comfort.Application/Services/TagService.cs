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

    public async Task AddTagToProductsAsync(Guid tagId, List<Guid> productIds)
    {
        foreach (var productId in productIds)
        {
            var product = await productRepository.GetByIdAsync(productId);

            if (product == null) continue;
            product.TagId = tagId;
                
            await productRepository.UpdateAsync(product.Id, product.Name, product.ShortName, product.Length,
                product.Width, product.Height, product.Description, product.Materials, product.PathToImageSchema,
                product.TagId);
        }
    }

    public async Task<Tag?> UpdateAsync(Guid id, string name, List<Guid> productIds)
    {
        return await tagRepository.UpdateAsync(id, name, productIds);
    }

    public async Task<Tag?> DeleteAsync(Guid id)
    {
        return await tagRepository.DeleteAsync(id);
    }

    public async Task<Tag?> CreateAsync(string name, List<Guid> productIds)
    {
        var tag = Tag.Create(Guid.NewGuid(), name, productIds);
        return await tagRepository.CreateAsync(tag);
    }
}