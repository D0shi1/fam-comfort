namespace fam_comfort.Application.Contract.ViewModels;

public class ContactRequest
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Rank { get; set; } = string.Empty;
    public string Languages { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}