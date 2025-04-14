using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class FacadeService
{
    private readonly IFacadeRepository _facadeRepository;

    public FacadeService(IFacadeRepository facadeRepository)
    {
        _facadeRepository = facadeRepository;
    }

    public async Task<List<Facade>> GetAllAsync()
    {
        return await _facadeRepository.GetAllAsync();
    }

    public async Task<Facade> CreateAsync(string name, string shortName, ushort length, ushort width, ushort height,
        string description, List<Color> colors, string materials, string pathToImage, string pathToImageSchema)
    {
        var facade = Facade.Create(Guid.NewGuid(), name, shortName, length, width, height, description, colors,
            materials, pathToImage, pathToImageSchema);
        return await _facadeRepository.Create(facade);
    }
}