namespace fam_comfort.Application.Contract.Dto;

public class ProductDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string ShortName { get; set; } = string.Empty;
    
    public ushort Length { get; set; }
    
    public ushort Width { get; set; }
    
    public ushort Height { get; set; }
    
    public string Description { get; set; } = string.Empty;

    public List<ColorDto> Colors { get; set; } = [];
    
    public string Materials { get; set; } = string.Empty;
    public string PathToImageSchema { get; set; } = string.Empty;
}
