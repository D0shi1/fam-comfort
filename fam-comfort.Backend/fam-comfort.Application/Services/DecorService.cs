using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class DecorService
{
    private readonly IDecorRepository _decorRepository;
    private readonly IDecorCategoryRepository _decorCategoryRepository;

    public DecorService(IDecorRepository decorRepository, IDecorCategoryRepository decorCategoryRepository)
    {
        _decorRepository = decorRepository;
        _decorCategoryRepository = decorCategoryRepository;
    }

    public async Task<List<Decor>?> GetAllAsync(Guid decorCategoryId)
    {
        var sectionExist = await _decorCategoryRepository.DecorCategoryExistsAsync(decorCategoryId);

        if (!sectionExist) return null;

        return await _decorRepository.GetAllAsync(decorCategoryId);
    }

    public async Task<Decor?> GetByIdAsync(Guid id)
    {
        return await _decorRepository.GetByIdAsync(id);
    }
    
    public async Task<Decor?> GetByNameAsync(string name)
    {
        return await _decorRepository.GetByNameAsync(name);
    }

    public async Task<Decor?> UpdateAsync(Guid decorId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        return await _decorRepository.UpdateAsync(decorId, name, shortName, length, width, height, description,
            materials, pathToImageSchema);
    }

    public async Task<Decor?> DeleteAsync(Guid id)
    {
        return await _decorRepository.DeleteAsync(id);
    }

    public async Task<Decor?> CreateAsync(Guid decorCategoryId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        var sectionExist = await _decorCategoryRepository.DecorCategoryExistsAsync(decorCategoryId);

        if (!sectionExist) return null;


        var decor = Decor.Create(Guid.NewGuid(), name, shortName, length, width, height, description, materials,
            pathToImageSchema, decorCategoryId);
        await _decorRepository.CreateAsync(decor);
        return decor;
    }
}