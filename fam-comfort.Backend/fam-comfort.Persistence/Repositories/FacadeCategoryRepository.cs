using fam_comfort.Application.Helpers;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class FacadeCategoryRepository(FamComfortDbContext context) : IFacadeCategoryRepository
{
    public async Task<List<FacadeCategory>> GetAllAsync(QueryObject query)
    {
        var facadeCategories = context.FacadesCategories.AsQueryable();

        if (!string.IsNullOrWhiteSpace(query.Name))
            facadeCategories = facadeCategories.Where(c => c.Name.Contains(query.Name));

        if (!string.IsNullOrWhiteSpace(query.SortBy))
        {
            if (query.SortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
            {
                facadeCategories = query.IsDescending
                    ? facadeCategories.OrderByDescending(f => f.Name)
                    : facadeCategories.OrderBy(s => s.Name);
            }
        }

        var skipNumber = (query.PageNumber - 1) * query.PageSize;

        return await facadeCategories.Skip(skipNumber).Take(query.PageSize).ToListAsync();
    }

    public async Task<FacadeCategory?> GetByIdAsync(Guid id)
    {
        return await context.FacadesCategories.FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task<FacadeCategory?> GetByNameAsync(string name)
    {
        return await context.FacadesCategories.FirstOrDefaultAsync(f => f.Name == name);
    }

    public async Task<FacadeCategory> CreateAsync(FacadeCategory facadeCategory)
    {
        await context.FacadesCategories.AddAsync(facadeCategory);
        await context.SaveChangesAsync();

        return facadeCategory;
    }

    public async Task<FacadeCategory?> UpdateAsync(Guid facadeCategoryId, string name, string pathToImage)
    {
        var facadeCategory = await GetByIdAsync(facadeCategoryId);
        if (facadeCategory == null) return null;

        if (name != string.Empty)
            facadeCategory.Name = name;
        if (pathToImage != string.Empty)
            facadeCategory.PathToImage = pathToImage;

        await context.SaveChangesAsync();

        return facadeCategory;
    }

    public async Task<FacadeCategory?> DeleteAsync(Guid id)
    {
        var facadeCategory = await GetByIdAsync(id);
        if (facadeCategory == null) return null;

        context.FacadesCategories.Remove(facadeCategory);
        await context.SaveChangesAsync();

        return facadeCategory;
    }

    public async Task<bool> FacadeCategoryExistsAsync(Guid id)
    {
        return await context.FacadesCategories.AnyAsync(s => s.Id == id);
    }
}