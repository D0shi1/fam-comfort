namespace fam_comfort.Application.Contract.Dto;

public class CategoryDto
{
    public Guid CategoryId { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string PathToImage { get; set; } = string.Empty;
}