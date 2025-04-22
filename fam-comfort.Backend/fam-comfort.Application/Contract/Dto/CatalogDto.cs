namespace fam_comfort.Application.Contract.Dto;

public class CatalogDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string PathToImage { get; set; } = string.Empty;
    public List<CategoryDto> Categories { get; set; } = [];
}