using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class TagRepository(FamComfortDbContext famComfortDbContext) : ITagRepository
{
    public async Task<List<Tag>> GetAllAsync()
    {
        return await famComfortDbContext.Tags.ToListAsync();
    }

    public async Task<Tag> CreateAsync(Tag tag)
    {
        await famComfortDbContext.Tags.AddAsync(tag);
        await famComfortDbContext.SaveChangesAsync();
        
        return tag;
    }

    public async Task<Tag?> GetByIdAsync(Guid tagId)
    {
        return await famComfortDbContext.Tags.FindAsync(tagId);
    }

    public async Task<Tag?> GetByNameAsync(string tagName)
    {
        return await famComfortDbContext.Tags.FirstOrDefaultAsync(t => t.Name == tagName);
    }

    public async Task<Tag?> UpdateAsync(Guid tagId, string name)
    {
        var tag = await famComfortDbContext.Tags.FindAsync(tagId);

        if (tag == null)
            return null;
        
        tag.Name = UpdateIfNotEmpty(name, tag.Name);
        
        await famComfortDbContext.SaveChangesAsync();
        
        return tag;
    }

    public async Task<Tag?> DeleteAsync(Guid tagId)
    {
        var tag = await famComfortDbContext.Tags.FindAsync(tagId);
        
        if(tag == null)
            return null;
        
        famComfortDbContext.Tags.Remove(tag);
        await famComfortDbContext.SaveChangesAsync();
        
        return tag;
    }

    public async Task<bool> TagExistsAsync(Guid tagId)
    {
        return await famComfortDbContext.Tags.AnyAsync(t => t.Id == tagId);
    }
    
    private string UpdateIfNotEmpty(string newValue, string currentValue) =>
        !string.IsNullOrEmpty(newValue) ? newValue : currentValue;
}