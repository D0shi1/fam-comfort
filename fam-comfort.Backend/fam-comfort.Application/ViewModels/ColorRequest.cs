namespace fam_comfort.Application.ViewModels;

public class ColorRequest
{
    public Guid FacadeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PathToImage { get; set; } = string.Empty;
}