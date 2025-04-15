using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class FacadeService(IFacadeRepository facadeRepository, IFacadeCategoryRepository facadeCategoryRepository)
{
    public async Task<List<Facade>?> GetAllAsync(Guid facadeCategoryId)
    {
        var sectionExist = await facadeCategoryRepository.FacadeCategoryExistsAsync(facadeCategoryId);

        if (!sectionExist) return null;

        return await facadeRepository.GetAllAsync(facadeCategoryId);
    }

    public async Task<Facade?> GetByIdAsync(Guid id)
    {
        return await facadeRepository.GetByIdAsync(id);
    }
    
    public async Task<Facade?> GetByColorAsync(Guid colorId)
    {
        return await facadeRepository.GetByColorAsync(colorId);
    }
    
    public async Task<Facade?> GetByNameAsync(string name)
    {
        return await facadeRepository.GetByNameAsync(name);
    }

    public async Task<Facade?> UpdateAsync(Guid facadeId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        return await facadeRepository.UpdateAsync(facadeId, name, shortName, length, width, height, description,
            materials, pathToImageSchema);
    }

    public async Task<Facade?> DeleteAsync(Guid id)
    {
        return await facadeRepository.DeleteAsync(id);
    }

    public async Task<Facade?> CreateAsync(Guid facadeCategoryId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        var sectionExist = await facadeCategoryRepository.FacadeCategoryExistsAsync(facadeCategoryId);

        if (!sectionExist) return null;


        var facade = Facade.Create(Guid.NewGuid(), name, shortName, length, width, height, description, materials,
            pathToImageSchema, facadeCategoryId);
        await facadeRepository.CreateAsync(facade);
        return facade;
    }
}