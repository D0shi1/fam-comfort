namespace fam_comfort.Application.ViewModels;

public class CategoryRequest
{
    public Guid CatalogId { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public string PathToImage { get; set; } = string.Empty;
}