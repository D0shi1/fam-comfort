using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Persistence.Repositories;

public class UserRepository(FamComfortDbContext context) : IUserRepository
{
    public async Task<User> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetByUsernameAsync(string username)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(User user)
    {
        throw new NotImplementedException();
    }
}