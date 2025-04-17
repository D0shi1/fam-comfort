using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class ColorService(IColorRepository colorRepository, IProductRepository productRepository)
{
    public async Task<List<Color>?> GetAllAsync(Guid facadeId)
    {
        var existFacade = await productRepository.ExistsAsync(facadeId);
        if (!existFacade) return null;

        return await colorRepository.GetAllAsync(facadeId);
    }
    
    public async Task<Color?> GetByIdAsync(Guid id)
    {
        return await colorRepository.GetByIdAsync(id);
    }

    public async Task<Color?> UpdateAsync(Guid id, string name, string pathToImage)
    {
        return await colorRepository.UpdateAsync(id, name, pathToImage);
    }
    
    public async Task<Color?> DeleteAsync(Guid id)
    {
        return await colorRepository.DeleteAsync(id);
    }

    public async Task<Color?> CreateAsync(Guid productId, string name, string pathToImage)
    {
        var existFacade = await productRepository.ExistsAsync(productId);
        if (!existFacade) return null;

        var color = Color.Create(Guid.NewGuid(), name, pathToImage, productId);
        await colorRepository.CreateAsync(color);
        
        return color;
    }
}