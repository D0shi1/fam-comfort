namespace fam_comfort.Application.Contract.ViewModels;

public class TagRequest
{
    public string Name { get; set; } = string.Empty;
    public List<Guid> ProductIds { get; set; } = [];
}