using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class ColorRepository(FamComfortDbContext context) : IColorRepository
{
    public async Task<List<Color>> GetAllAsync(Guid productId)
    {
        return await context.Colors.Where(c => c.ProductId == productId).ToListAsync();
    }

    public async Task<Color> CreateAsync(Color color)
    {
        await context.Colors.AddAsync(color);
        await context.SaveChangesAsync();
        return color;
    }

    public async Task<Color?> GetByIdAsync(Guid colorId)
    {
        return await context.Colors.FirstOrDefaultAsync(c => c.Id == colorId);
    }

    public async Task<Color?> UpdateAsync(Guid colorId, string name, string pathToImage)
    {
        var color = await GetByIdAsync(colorId);
        if (color is null) return null;
        
        if(name != string.Empty)
            color.Name = name;
        if(pathToImage != string.Empty)
            color.PathToImage = pathToImage;
        
        await context.SaveChangesAsync();
        
        return color;
    }

    public async Task<Color?> DeleteAsync(Guid colorId)
    {
        var color = await GetByIdAsync(colorId);
        if (color is null) return null;
        
        context.Colors.Remove(color);
        await context.SaveChangesAsync();
        
        return color;
    }
}