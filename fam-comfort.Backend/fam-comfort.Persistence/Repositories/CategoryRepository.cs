using fam_comfort.Application.Helpers;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly FamComfortDbContext _context;

    public CategoryRepository(FamComfortDbContext context)
    {
        _context = context;
    }
    public async Task<List<Category>> GetAllAsync(Guid catalogId)
    {
        return await _context.Categories.Where(c => c.CatalogId == catalogId).ToListAsync();
    }

    public async Task<Category?> GetByIdAsync(Guid catalogId)
    {
        return await _context.Categories.FirstOrDefaultAsync(c => c.Id == catalogId);
    }

    public async Task<List<Category>?> GetByNameAsync(string name)
    {
        var catalog = await _context.Catalogs.Include(catalog => catalog.Categories).FirstOrDefaultAsync(c => c.Name == name);
        return catalog?.Categories;
    }

    public async Task<Category> CreateAsync(Category catalog)
    {
        await _context.Categories.AddAsync(catalog);
        await _context.SaveChangesAsync();

        return catalog;
    }

    public async Task<Category?> UpdateAsync(Guid catalogId, string name, string pathToImage)
    {
        var catalog = await GetByIdAsync(catalogId);
        if (catalog is null) return null;
        
        catalog.Name = name;
        catalog.PathToImage = pathToImage;
        
        await _context.SaveChangesAsync();

        return catalog;
    }

    public async Task<Category?> DeleteAsync(Guid catalogId)
    {
        var catalog = await GetByIdAsync(catalogId);
        if (catalog is null) return null;
        
        _context.Categories.Remove(catalog);
        await _context.SaveChangesAsync();

        return catalog;
    }

    public async Task<bool> ExistsAsync(Guid categoryd)
    {
        return await _context.Categories.AnyAsync(c => c.Id == categoryd);
    }
}