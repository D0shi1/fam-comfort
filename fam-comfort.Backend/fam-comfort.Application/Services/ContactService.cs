using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class ContactService(IContactRepository contactRepository)
{
    public async Task<List<Contact>?> GetAllAsync()
    {
        return await contactRepository.GetAllAsync();
    }

    public async Task<Contact?> GetByIdAsync(Guid contactId)
    {
        return await contactRepository.GetByIdAsync(contactId);
    }

    public async Task<Contact?> GetByNameAsync(string name)
    {
        return await contactRepository.GetByNameAsync(name);
    }

    public async Task<Contact?> CreateAsync(string firstName, string lastName, string email, string phoneNumber,
        string rank, string languages, string description)
    {
        var contact = Contact.Create(Guid.NewGuid(), firstName, lastName, email, phoneNumber, rank, languages,
            description);
        await contactRepository.CreateAsync(contact);
        
        return contact;
    }

    public async Task<Contact?> UpdateAsync(Guid id, string firstName, string lastName, string email, string phoneNumber,
        string rank, string languages, string description)
    {
        return await contactRepository.UpdateAsync(id, firstName, lastName, email, phoneNumber, rank, languages,
            description);
    }

    public async Task<Contact?> DeleteAsync(Guid id)
    {
        return await contactRepository.DeleteAsync(id);
    }
}