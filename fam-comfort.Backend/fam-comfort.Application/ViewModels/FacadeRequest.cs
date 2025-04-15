namespace fam_comfort.Application.ViewModels;

public class FacadeRequest
{
    public Guid FacadeCategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public ushort Length { get; set; }
    public ushort Width { get; set; }
    public ushort Height { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Materials { get; set; } = string.Empty;
    public string PathToImageSchema { get; set; } = string.Empty;
}