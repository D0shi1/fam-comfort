namespace fam_comfort.WebApi.Contract;

public class CategoryDto
{
    public Guid CategoryId { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string PathToImage { get; set; } = string.Empty;
}