using fam_comfort.Application.Interfaces.Authentication;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Core.Models;

namespace fam_comfort.Application.Services;

public class UserService(IPasswordHasher passwordHasher, IUserRepository userRepository, IJwtProvider jwtProvider)
{
    public async Task<User> Register(string username, string password)
    {
        if (await userRepository.GetByUsernameAsync(username) is not null)
        {
            throw new Exception("Username already exists");
        }
        
        var hashedPassword = passwordHasher.Generate(password);
        
        var user = User.Create(Guid.NewGuid(), username, hashedPassword);

        await userRepository.AddAsync(user);
        
        return user;
    }

    public async Task<string> Login(string username, string password)
    {
        var user = await userRepository.GetByUsernameAsync(username);

        if (user == null)
        {
            throw new UnauthorizedAccessException("Invalid username or password");
        }
        
        var result = passwordHasher.Verify(password, user.PasswordHash);

        if (result == false)
        {
            throw new UnauthorizedAccessException("Invalid username or password");
        }

        var token = jwtProvider.GenerateToken(user);
        
        return token;
    }
}