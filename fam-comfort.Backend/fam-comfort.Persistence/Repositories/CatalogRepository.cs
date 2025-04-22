using fam_comfort.Application.Helpers;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class CatalogRepository : ICatalogRepository
{
    private readonly FamComfortDbContext _context;

    public CatalogRepository(FamComfortDbContext context)
    {
        _context = context;
    }
    public async Task<List<Catalog>> GetAllAsync(QueryObject query)
    {
        var catalogs = _context.Catalogs.Include(c => c.Categories).AsQueryable();

        if (!string.IsNullOrWhiteSpace(query.Name))
            catalogs = catalogs.Where(c => c.Name.Contains(query.Name));

        if (!string.IsNullOrWhiteSpace(query.SortBy))
        {
            if (query.SortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
            {
                catalogs = query.IsDescending
                    ? catalogs.OrderByDescending(f => f.Name)
                    : catalogs.OrderBy(s => s.Name);
            }
        }

        var skipNumber = (query.PageNumber - 1) * query.PageSize;

        return await catalogs.Skip(skipNumber).Take(query.PageSize).ToListAsync();
    }

    public async Task<Catalog?> GetByIdAsync(Guid catalogId)
    {
        return await _context.Catalogs.Include(c => c.Categories).ThenInclude(c => c).FirstOrDefaultAsync(c => c.Id == catalogId);
    }

    public async Task<Catalog?> GetByNameAsync(string name)
    {
        return await _context.Catalogs.Include(c => c.Categories).FirstOrDefaultAsync(c => c.Name == name);
    }

    public async Task<Catalog> CreateAsync(Catalog catalog)
    {
        await _context.Catalogs.AddAsync(catalog);
        await _context.SaveChangesAsync();

        return catalog;
    }

    public async Task<Catalog?> UpdateAsync(Guid catalogId, string name, string pathToImage)
    {
        var catalog = await GetByIdAsync(catalogId);

        if (catalog is null) return null;
        
        catalog.Name = name;
        catalog.PathToImage = pathToImage;
        
        await _context.SaveChangesAsync();
        return catalog;
    }

    public async Task<Catalog?> DeleteAsync(Guid catalogId)
    {
        var catalog = await GetByIdAsync(catalogId);
        
        if(catalog is null) return null;
        
        _context.Remove(catalog);
        await _context.SaveChangesAsync();
        
        return catalog;
    }

    public async Task<bool> ExistsAsync(Guid catalogId)
    {
        return await _context.Catalogs.AnyAsync(s => s.Id == catalogId);
    }
}