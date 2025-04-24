namespace fam_comfort.Core.Models;

public class Ticket
{
    private Ticket(Guid id, string title, string phoneNumber, string email)
    {
        Id = id;
        Title = title;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    public Guid Id { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Title { get; set; }

    public static Ticket Create(Guid id, string title, string phoneNumber, string email)
    {
        return new Ticket(id, title, phoneNumber, email);
    }
}