using fam_comfort.Application.Helpers;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class DecorCategoryRepository(FamComfortDbContext context) : IDecorCategoryRepository
{
    public async Task<List<DecorCategory>> GetAllAsync(QueryObject query)
    {
        var decorCategories = context.DecorsCategories.AsQueryable();

        if (!string.IsNullOrWhiteSpace(query.Name))
            decorCategories = decorCategories.Where(c => c.Name.Contains(query.Name));

        if (!string.IsNullOrWhiteSpace(query.SortBy))
        {
            if (query.SortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
            {
                decorCategories = query.IsDescending
                    ? decorCategories.OrderByDescending(f => f.Name)
                    : decorCategories.OrderBy(s => s.Name);
            }
        }

        var skipNumber = (query.PageNumber - 1) * query.PageSize;

        return await decorCategories.Skip(skipNumber).Take(query.PageSize).ToListAsync();
    }

    public async Task<DecorCategory?> GetByIdAsync(Guid id)
    {
        return await context.DecorsCategories.FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task<DecorCategory?> GetByNameAsync(string name)
    {
        return await context.DecorsCategories.FirstOrDefaultAsync(f => f.Name == name);
    }

    public async Task<DecorCategory> CreateAsync(DecorCategory decorCategory)
    {
        await context.DecorsCategories.AddAsync(decorCategory);
        await context.SaveChangesAsync();

        return decorCategory;
    }

    public async Task<DecorCategory?> UpdateAsync(Guid decorCategoryId, string name, string pathToImage)
    {
        var decorCategory = await GetByIdAsync(decorCategoryId);
        if (decorCategory == null) return null;

        if (name != string.Empty)
            decorCategory.Name = name;
        if (pathToImage != string.Empty)
            decorCategory.PathToImage = pathToImage;

        await context.SaveChangesAsync();

        return decorCategory;
    }

    public async Task<DecorCategory?> DeleteAsync(Guid decorCategoryId)
    {
        var decorCategory = await GetByIdAsync(decorCategoryId);
        if (decorCategory == null) return null;

        context.DecorsCategories.Remove(decorCategory);
        await context.SaveChangesAsync();

        return decorCategory;
    }

    public async Task<bool> DecorCategoryExistsAsync(Guid id)
    {
        return await context.DecorsCategories.AnyAsync(s => s.Id == id);
    }
}