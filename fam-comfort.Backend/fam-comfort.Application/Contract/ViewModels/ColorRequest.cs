namespace fam_comfort.Application.Contract.ViewModels;

public class ColorRequest
{
    public Guid ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PathToImage { get; set; } = string.Empty;
}