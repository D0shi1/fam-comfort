using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class ColorRepository : IColorRepository
{
    private readonly FamComfortDbContext _context;

    public ColorRepository(FamComfortDbContext context)
    {
        _context = context;
    }
    public async Task<List<Color>> GetAllAsync(Guid facadeId)
    {
        return await _context.Colors.Where(c => c.FacadeId == facadeId).ToListAsync();
    }

    public async Task<Color> CreateAsync(Color color)
    {
        await _context.Colors.AddAsync(color);
        await _context.SaveChangesAsync();
        return color;
    }

    public async Task<Color?> GetByIdAsync(Guid colorId)
    {
        return await _context.Colors.FirstOrDefaultAsync(c => c.Id == colorId);
    }

    public async Task<Color?> UpdateAsync(Guid colorId, string name, string pathToImage)
    {
        var color = await GetByIdAsync(colorId);
        if (color is null) return null;
        
        if(name != string.Empty)
            color.Name = name;
        if(pathToImage != string.Empty)
            color.PathToImage = pathToImage;
        
        await _context.SaveChangesAsync();
        
        return color;
    }

    public async Task<Color?> DeleteAsync(Guid colorId)
    {
        var color = await GetByIdAsync(colorId);
        if (color is null) return null;
        
        _context.Colors.Remove(color);
        await _context.SaveChangesAsync();
        
        return color;
    }
}