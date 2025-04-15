using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class FacadeService
{
    private readonly IFacadeRepository _facadeRepository;
    private readonly IFacadeCategoryRepository _facadeCategoryRepository;

    public FacadeService(IFacadeRepository facadeRepository, IFacadeCategoryRepository facadeCategoryRepository)
    {
        _facadeRepository = facadeRepository;
        _facadeCategoryRepository = facadeCategoryRepository;
    }

    public async Task<List<Facade>?> GetAllAsync(Guid facadeCategoryId)
    {
        var sectionExist = await _facadeCategoryRepository.FacadeCategoryExistsAsync(facadeCategoryId);

        if (!sectionExist) return null;

        return await _facadeRepository.GetAllAsync(facadeCategoryId);
    }

    public async Task<Facade?> GetByIdAsync(Guid id)
    {
        return await _facadeRepository.GetByIdAsync(id);
    }
    
    public async Task<Facade?> GetByColorAsync(Guid colorId)
    {
        return await _facadeRepository.GetByColorAsync(colorId);
    }
    
    public async Task<Facade?> GetByNameAsync(string name)
    {
        return await _facadeRepository.GetByNameAsync(name);
    }

    public async Task<Facade?> UpdateAsync(Guid facadeId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        return await _facadeRepository.UpdateAsync(facadeId, name, shortName, length, width, height, description,
            materials, pathToImageSchema);
    }

    public async Task<Facade?> DeleteAsync(Guid id)
    {
        return await _facadeRepository.DeleteAsync(id);
    }

    public async Task<Facade?> CreateAsync(Guid facadeCategoryId, string name, string shortName, ushort length,
        ushort width, ushort height, string description, string materials, string pathToImageSchema)
    {
        var sectionExist = await _facadeCategoryRepository.FacadeCategoryExistsAsync(facadeCategoryId);

        if (!sectionExist) return null;


        var facade = Facade.Create(Guid.NewGuid(), name, shortName, length, width, height, description, materials,
            pathToImageSchema, facadeCategoryId);
        await _facadeRepository.CreateAsync(facade);
        return facade;
    }
}