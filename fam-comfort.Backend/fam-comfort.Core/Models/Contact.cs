namespace fam_comfort.Core.Models;

public class Contact
{
    private Contact(Guid id, string firstName, string lastName, string email, string phoneNumber, string rank,
        string languages, string description)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Rank = rank;
        Languages = languages;
        Description = description;
    }

    public Contact()
    {
    }
    
    public Guid Id { get; set; }
    
    public string FirstName { get; set; } = string.Empty;
    
    public string LastName { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    public string PhoneNumber { get; set; } = string.Empty;
    
    public string Rank { get; set; } = string.Empty;
    
    public string Languages { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;

    public static Contact Create(Guid id, string firstName, string lastName, string email, string phoneNumber,
        string rank, string languages, string description)
    {
        return new Contact(id, firstName, lastName, email, phoneNumber, rank, languages, description);
    }
}