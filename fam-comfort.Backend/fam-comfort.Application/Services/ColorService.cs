using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class ColorService
{
    private readonly IColorRepository _colorRepository;
    private readonly IFacadeRepository _facadeRepository;

    public ColorService(IColorRepository colorRepository, IFacadeRepository facadeRepository)
    {
        _colorRepository = colorRepository;
        _facadeRepository = facadeRepository;
    }

    public async Task<List<Color>?> GetAllAsync(Guid facadeId)
    {
        var existFacade = await _facadeRepository.FacadeExistsAsync(facadeId);
        if (!existFacade) return null;

        return await _colorRepository.GetAllAsync(facadeId);
    }
    
    public async Task<Color?> GetByIdAsync(Guid id)
    {
        return await _colorRepository.GetByIdAsync(id);
    }

    public async Task<Color?> UpdateAsync(Guid id, string name, string pathToImage)
    {
        return await _colorRepository.UpdateAsync(id, name, pathToImage);
    }
    
    public async Task<Color?> DeleteAsync(Guid id)
    {
        return await _colorRepository.DeleteAsync(id);
    }

    public async Task<Color?> CreateAsync(Guid facadeId, string name, string pathToImage)
    {
        var existFacade = await _facadeRepository.FacadeExistsAsync(facadeId);
        if (!existFacade) return null;

        var color = Color.Create(Guid.NewGuid(), name, pathToImage, facadeId);
        await _colorRepository.CreateAsync(color);
        
        return color;
    }
}