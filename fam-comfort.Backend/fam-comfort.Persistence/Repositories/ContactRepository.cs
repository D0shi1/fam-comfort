using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class ContactRepository(FamComfortDbContext context) : IContactRepository
{
    public async Task<List<Contact>> GetAllAsync()
    {
        return await context.Contacts.ToListAsync();
    }

    public async Task<Contact?> GetByIdAsync(Guid contactId)
    {
        return await context.Contacts.FindAsync(contactId);
    }

    public async Task<Contact?> GetByNameAsync(string name)
    {
        return await context.Contacts.FirstOrDefaultAsync(c => c.FirstName == name);
    }

    public async Task<Contact> CreateAsync(Contact contact)
    {
        await context.Contacts.AddAsync(contact);
        await context.SaveChangesAsync();
        
        return contact;
    }

    public async Task<Contact?> UpdateAsync(Guid contactId, string firstName, string lastName, string email,
        string phoneNumber, string rank, string languages, string description)
    {
        var contact = await GetByIdAsync(contactId);
        
        if(contact == null) return null;
        
        contact.FirstName = UpdateIfNotEmpty(firstName, contact.FirstName);
        contact.LastName = UpdateIfNotEmpty(lastName, contact.LastName);
        contact.Email = UpdateIfNotEmpty(email, contact.Email);
        contact.PhoneNumber = UpdateIfNotEmpty(phoneNumber, contact.PhoneNumber);
        contact.Rank = UpdateIfNotEmpty(rank, contact.Rank);
        contact.Languages = UpdateIfNotEmpty(languages, contact.Languages);
        contact.Description = UpdateIfNotEmpty(description, contact.Description);
        
        await context.SaveChangesAsync();
        return contact;
    }

    public async Task<Contact?> DeleteAsync(Guid contactId)
    {
        var contact = await GetByIdAsync(contactId);
        
        if(contact == null) return null;
        
        context.Contacts.Remove(contact);
        await context.SaveChangesAsync();
        
        return contact;
    }

    public async Task<bool> ContactExistsAsync(Guid contactId)
    {
        return await context.Contacts.AnyAsync(p => p.Id == contactId);
    }
    
    private string UpdateIfNotEmpty(string newValue, string currentValue) =>
        !string.IsNullOrEmpty(newValue) ? newValue : currentValue;
}