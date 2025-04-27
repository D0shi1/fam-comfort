using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface ITagRepository
{
    Task<List<Tag>> GetAllAsync();
    Task<Tag> CreateAsync(Tag tag);
    Task<Tag?> GetByIdAsync(Guid tagId);
    Task<Tag?> GetByNameAsync(string tagName);
    Task<Tag?> UpdateAsync(Guid tagId, string name, List<Guid> productIds);
    Task<Tag?> DeleteAsync(Guid tagId);
    Task<bool> TagExistsAsync(Guid tagId);
}