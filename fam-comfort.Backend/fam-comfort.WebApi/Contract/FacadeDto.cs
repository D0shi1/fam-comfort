using fam_comfort.Core.Models;

namespace fam_comfort.WebApi.Contract;

public class FacadeDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string ShortName { get; set; } = string.Empty;
    
    public ushort Length { get; set; }
    
    public ushort Width { get; set; }
    
    public ushort Height { get; set; }
    
    public string Description { get; set; } = string.Empty;

    public List<Color> Colors { get; set; } = [];
    
    public string Materials { get; set; } = string.Empty;

    public string PathToImage { get; set; } = string.Empty;
    
    public string PathToImageSchema { get; set; } = string.Empty;
}