namespace fam_comfort.WebApi.Contract;

public class DecorCategoryDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string PathToImage { get; set; } = string.Empty;
}