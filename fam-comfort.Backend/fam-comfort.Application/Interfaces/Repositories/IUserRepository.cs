using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Repositories;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id);
    Task<IEnumerable<User>> GetAllAsync();
    Task<User?> GetByUsernameAsync(string username);
    Task<User?> AddAsync(User user);
    Task<User?>  UpdateAsync(Guid userId, string username, string passwordHash);
    Task<User?>  DeleteAsync(Guid userId);
}