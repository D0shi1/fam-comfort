using fam_comfort.Application.Contract.ViewModels;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class ProductService
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }
    
    public async Task<List<Product>?> GetAllAsync(Guid categoryId)
    {
        var sectionExist = await _categoryRepository.ExistsAsync(categoryId);

        if (!sectionExist) return null;

        return await _productRepository.GetAllAsync(categoryId);
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        return await _productRepository.GetByIdAsync(id);
    }
    
    public async Task<Product?> GetByColorAsync(Guid colorId)
    {
        return await _productRepository.GetByColorAsync(colorId);
    }
    
    public async Task<List<Product>?> GetByNameAsync(string name)
    {
        return await _productRepository.GetByNameAsync(name);
    }

    public async Task<Product?> UpdateAsync(Guid productId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema, Guid? tagId)
    {
        return await _productRepository.UpdateAsync(productId, name, shortName, length, width, height, description,
            materials, pathToImageSchema, tagId);
    }

    public async Task<Product?> DeleteAsync(Guid id)
    {
        return await _productRepository.DeleteAsync(id);
    }

    public async Task<Product?> CreateAsync(Guid categoryId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema, Guid? tagId)
    {
        var sectionExist = await _categoryRepository.ExistsAsync(categoryId);

        if (!sectionExist) return null;
        
        var product = Product.Create(Guid.NewGuid(), name, shortName, length, width, height, description, materials,
            pathToImageSchema, categoryId, tagId);
        await _productRepository.CreateAsync(product);
        return product;
    }
}