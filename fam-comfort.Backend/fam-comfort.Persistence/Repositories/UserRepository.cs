using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence.Repositories;

public class UserRepository(FamComfortDbContext context) : IUserRepository
{
    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await context.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await context.Users.ToListAsync();
    }

    public async Task<User?> GetByUsernameAsync(string username)
    {
        return await context.Users.FirstOrDefaultAsync(u => u.Username == username);
    }

    public async Task<User?> AddAsync(User user)
    {
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
        
        return user;
    }

    public async Task<User?> UpdateAsync(Guid userId, string username, string passwordHash)
    {
        var user = await GetByIdAsync(userId);
        if (user == null) return null;
        
        user.Username = UpdateIfNotEmpty(username, user.Username);
        user.PasswordHash = UpdateIfNotEmpty(passwordHash, user.PasswordHash);
        
        await context.SaveChangesAsync();
        
        return user;
    }

    public async Task<User?> DeleteAsync(Guid userId)
    {
        var user = await GetByIdAsync(userId);
        if (user == null) return null;
        
        context.Users.Remove(user);
        await context.SaveChangesAsync();
        
        return user;
    }
    
    private static string UpdateIfNotEmpty(string newValue, string currentValue) =>
        !string.IsNullOrEmpty(newValue) ? newValue : currentValue;
}