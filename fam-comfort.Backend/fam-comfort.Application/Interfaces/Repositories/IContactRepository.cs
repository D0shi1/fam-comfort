using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IContactRepository
{
    Task<List<Contact>> GetAllAsync();
    Task<Contact?> GetByIdAsync(Guid id);
    Task<Contact?> GetByNameAsync(string name);
    Task<Contact> CreateAsync(Contact contact);
    Task<Contact?> UpdateAsync(Guid contactId, string firstName, string lastName, string email, string phoneNumber,
        string rank, string languages, string description);
    Task<Contact?> DeleteAsync(Guid contactId);
    Task<bool> ContactExistsAsync(Guid id);
}