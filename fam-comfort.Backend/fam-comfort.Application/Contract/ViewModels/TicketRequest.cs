namespace fam_comfort.Application.Contract.ViewModels;

public class TicketRequest
{
    public string Title { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}