using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class FacadeRepository(FamComfortDbContext famComfortDbContext) : IFacadeRepository
{
    public async Task<List<Facade>> GetAllAsync(Guid facadeCategoryId)
    {
        return await famComfortDbContext.Facades.Where(f => f.FacadeCategoryId == facadeCategoryId).Include(c => c.Colors).ToListAsync();
    }

    public async Task<Facade> CreateAsync(Facade facade)
    {
        await famComfortDbContext.Facades.AddAsync(facade);
        await famComfortDbContext.SaveChangesAsync();
        return facade;
    }

    public async Task<Facade?> GetByIdAsync(Guid facadeId)
    {
        return await famComfortDbContext.Facades.FirstOrDefaultAsync(f => f.Id == facadeId);
    }

    public async Task<Facade?> GetByColorAsync(Guid colorId)
    {
        var color = await famComfortDbContext.Colors.Include(color => color.Facade).FirstOrDefaultAsync(c => c.Id == colorId);
        
        return color?.Facade;
    }

    public async Task<Facade?> GetByNameAsync(string name)
    {
        return await famComfortDbContext.Facades.FirstOrDefaultAsync(f => f.Name == name);
    }

    public async Task<Facade?> UpdateAsync(Guid facadeId, string name, string shortName, ushort length,
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

        await famComfortDbContext.SaveChangesAsync();

        return facade;
    }

    public async Task<Facade?> DeleteAsync(Guid facadeId)
    {
        var facade = await GetByIdAsync(facadeId);
        if (facade == null) return null;

        famComfortDbContext.Facades.Remove(facade);
        await famComfortDbContext.SaveChangesAsync();

        return facade;
    }

    public async Task<bool> FacadeExistsAsync(Guid id)
    {
        return await famComfortDbContext.Facades.AnyAsync(s => s.Id == id);
    }
    
    private string UpdateIfNotEmpty(string newValue, string currentValue) =>
        !string.IsNullOrEmpty(newValue) ? newValue : currentValue;
}