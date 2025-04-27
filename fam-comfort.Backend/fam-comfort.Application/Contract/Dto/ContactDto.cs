namespace fam_comfort.Application.Contract.Dto;

public class ContactDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Rank { get; set; } = string.Empty;
    public string Languages { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}