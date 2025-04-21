namespace fam_comfort.WebApi.Contract;

public class CatalogDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string PathToImage { get; set; } = string.Empty;
    public List<CategoryDto> Categories { get; set; } = [];
}