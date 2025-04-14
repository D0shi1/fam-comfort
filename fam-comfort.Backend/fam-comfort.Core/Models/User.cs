namespace fam_comfort.Core.Models;

public class User
{
    private User(Guid id, string username, string passwordHash)
    {
        Id = id;
        Username = username;
        PasswordHash = passwordHash;
    }

    public User()
    {
    }
    
    public Guid Id { get; set; }
    
    public string Username { get; set; } = string.Empty;
    
    public string PasswordHash { get; set; } = string.Empty;

    public static User? Create(Guid id, string username, string passwordHash)
    {
        return new User(id, username, passwordHash);
    }
}