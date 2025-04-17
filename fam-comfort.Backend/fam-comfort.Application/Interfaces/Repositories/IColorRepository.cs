using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IColorRepository
{
    Task<List<Color>> GetAllAsync(Guid productId);
    Task<Color> CreateAsync(Color color);
    Task<Color?> GetByIdAsync(Guid colorId);
    Task<Color?> UpdateAsync(Guid colorId, string name, string pathToImage);
    Task<Color?> DeleteAsync(Guid colorId);
}