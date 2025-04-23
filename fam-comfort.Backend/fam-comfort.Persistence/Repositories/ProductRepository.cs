using System.Linq.Expressions;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly FamComfortDbContext _context;

    public ProductRepository(FamComfortDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>?> GetAllAsync(Guid categoryId)
    {
        return await _context.Products.Include(c => c.Colors).Where(p => p.CategoryId == categoryId).ToListAsync();
    }

    public async Task<List<Product>?> GetAsync(
        Expression<Func<Product, bool>>? filter = null,
        Func<IQueryable<Product>, IOrderedQueryable<Product>>? orderBy = null,
        string includeProperties = "")
    {
        IQueryable<Product> query = _context.Products;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        query = includeProperties.Split([','], StringSplitOptions.RemoveEmptyEntries).Aggregate(query,
            (current, includeProperty) => current.Include(includeProperty));

        if (orderBy != null)
        {
            return await orderBy(query).ToListAsync();
        }
        
        return await query.ToListAsync();
    }

    public async Task<Product> CreateAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();

        return product;
    }

    public async Task<Product?> GetByIdAsync(Guid productId)
    {
        return await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
    }

    public async Task<Product?> GetByColorAsync(Guid colorId)
    {
        var color = await _context.Colors.Include(color => color.Product).FirstOrDefaultAsync(c => c.Id == colorId);

        return color?.Product;
    }

    public async Task<List<Product>?> GetByNameAsync(string name)
    {
        return await _context.Products.Include(c => c.Colors).Where(c => c.Category.Name.ToLower().StartsWith(name.ToLower())).ToListAsync();
    }

    public async Task<Product?> UpdateAsync(Guid productId, string name, string shortName, ushort length, ushort width,
        ushort height,
        string description, string materials, string pathToImageSchema, Guid? tagId)
    {
        var product = await GetByIdAsync(productId);
        
        if(product is null) return null;
        
        product.Name = UpdateIfNotEmpty(name, product.Name);
        product.ShortName = UpdateIfNotEmpty(shortName, product.ShortName);
        product.Length = length > 0 ? length : product.Length;
        product.Width = width > 0 ? width : product.Width;
        product.Height = height > 0 ? height : product.Height;
        product.Description = UpdateIfNotEmpty(description, product.Description);
        product.Materials = UpdateIfNotEmpty(name, product.Name);
        product.PathToImageSchema = UpdateIfNotEmpty(name, product.Name);
        product.TagId = tagId;
        
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product?> DeleteAsync(Guid productId)
    {
        var product = await GetByIdAsync(productId);
        
        if(product is null) return null;
        
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return product;
    }

    public async Task<bool> ExistsAsync(Guid productId)
    {
        return await _context.Products.AnyAsync(p => p.Id == productId);
    }

    private string UpdateIfNotEmpty(string newValue, string currentValue) =>
        !string.IsNullOrEmpty(newValue) ? newValue : currentValue;
}