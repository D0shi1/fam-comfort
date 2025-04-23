using System.Linq.Expressions;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IProductRepository
{
    Task<List<Product>?> GetAllAsync(Guid categoryId);
    Task<List<Product>?> GetAsync(Expression<Func<Product, bool>>? filter = null, Func<IQueryable<Product>,
            IOrderedQueryable<Product>>? orderBy = null, string includeProperties = "");
    Task<Product> CreateAsync(Product product);
    Task<Product?> GetByIdAsync(Guid productId);
    Task<Product?> GetByColorAsync(Guid colorId);
    Task<List<Product>?> GetByTagAsync(Guid tagId);
    Task<List<Product>?> GetByNameAsync(string name);

    Task<Product?> UpdateAsync(Guid productId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema, Guid? tagId);

    Task<Product?> DeleteAsync(Guid productId);
    Task<bool> ExistsAsync(Guid productId);
}