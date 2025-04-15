using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class DecorRepository : IDecorRepository
{
    private readonly FamComfortDbContext _famComfortDbContext;

    public DecorRepository(FamComfortDbContext famComfortDbContext)
    {
        _famComfortDbContext = famComfortDbContext;
    }
    public async Task<List<Decor>> GetAllAsync(Guid decorCategoryId)
    {
        return await _famComfortDbContext.Decors.Where(f => f.DecorCategoryId == decorCategoryId).ToListAsync();
    }

    public async Task<Decor> CreateAsync(Decor facade)
    {
        await _famComfortDbContext.Decors.AddAsync(facade);
        await _famComfortDbContext.SaveChangesAsync();
        return facade;
    }

    public async Task<Decor?> GetByIdAsync(Guid facadeId)
    {
        return await _famComfortDbContext.Decors.FirstOrDefaultAsync(f => f.Id == facadeId);
    }
    

    public async Task<Decor?> GetByNameAsync(string name)
    {
        return await _famComfortDbContext.Decors.FirstOrDefaultAsync(f => f.Name == name);
    }

    public async Task<Decor?> UpdateAsync(Guid facadeId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        var facade = await GetByIdAsync(facadeId);
        if (facade == null) return null;

        facade.Name = UpdateIfNotEmpty(name, facade.Name);
        facade.ShortName = UpdateIfNotEmpty(shortName, facade.ShortName);
        facade.Length = length > 0 ? length : facade.Length;
        facade.Width = width > 0 ? width : facade.Width;
        facade.Height = height > 0 ? height : facade.Height;
        facade.Description = UpdateIfNotEmpty(description, facade.Description);
        facade.Materials = UpdateIfNotEmpty(name, facade.Name);
        facade.PathToImageSchema = UpdateIfNotEmpty(name, facade.Name);

        await _famComfortDbContext.SaveChangesAsync();

        return facade;
    }

    public async Task<Decor?> DeleteAsync(Guid facadeId)
    {
        var facade = await GetByIdAsync(facadeId);
        if (facade == null) return null;

        _famComfortDbContext.Decors.Remove(facade);
        await _famComfortDbContext.SaveChangesAsync();

        return facade;
    }

    public async Task<bool> FacadeExistsAsync(Guid id)
    {
        return await _famComfortDbContext.Decors.AnyAsync(s => s.Id == id);
    }
    
    private string UpdateIfNotEmpty(string newValue, string currentValue) =>
        !string.IsNullOrEmpty(newValue) ? newValue : currentValue;
}