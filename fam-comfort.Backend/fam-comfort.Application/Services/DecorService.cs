using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class DecorService(IDecorRepository decorRepository, IDecorCategoryRepository decorCategoryRepository)
{
    public async Task<List<Decor>?> GetAllAsync(Guid decorCategoryId)
    {
        var sectionExist = await decorCategoryRepository.DecorCategoryExistsAsync(decorCategoryId);

        if (!sectionExist) return null;

        return await decorRepository.GetAllAsync(decorCategoryId);
    }

    public async Task<Decor?> GetByIdAsync(Guid id)
    {
        return await decorRepository.GetByIdAsync(id);
    }
    
    public async Task<Decor?> GetByNameAsync(string name)
    {
        return await decorRepository.GetByNameAsync(name);
    }

    public async Task<Decor?> UpdateAsync(Guid decorId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        return await decorRepository.UpdateAsync(decorId, name, shortName, length, width, height, description,
            materials, pathToImageSchema);
    }

    public async Task<Decor?> DeleteAsync(Guid id)
    {
        return await decorRepository.DeleteAsync(id);
    }

    public async Task<Decor?> CreateAsync(Guid decorCategoryId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        var sectionExist = await decorCategoryRepository.DecorCategoryExistsAsync(decorCategoryId);

        if (!sectionExist) return null;


        var decor = Decor.Create(Guid.NewGuid(), name, shortName, length, width, height, description, materials,
            pathToImageSchema, decorCategoryId);
        await decorRepository.CreateAsync(decor);
        return decor;
    }
}