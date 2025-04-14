namespace fam_comfort.Core.Models;

public class Facade
{
    private Facade(Guid id, string name, string shortName, uint length, uint width, uint height, string description,
        List<Color> colors, string materials, string pathToImage, string pathToImageSchema)
    {
        Id = id;
        Name = name;
        ShortName = shortName;
        Length = length;
        Width = width;
        Height = height;
        Description = description;
        Colors = colors;
        Materials = materials;
        PathToImage = pathToImage;
        PathToImageSchema = pathToImageSchema;
    }

    public Facade()
    {
    }
    
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string ShortName { get; set; } = string.Empty;
    
    public uint Length { get; set; }
    
    public uint Width { get; set; }
    
    public uint Height { get; set; }
    
    public string Description { get; set; } = string.Empty;

    public List<Color> Colors { get; set; } = [];
    
    public string Materials { get; set; } = string.Empty;

    public string PathToImage { get; set; } = string.Empty;
    
    public string PathToImageSchema { get; set; } = string.Empty;
    
    public Guid FacadeCategoryId { get; set; }
    
    public FacadeCategory FacadeCategory { get; set; }

    public static Facade? Create(Guid id, string name, string shortName, uint length, uint width, uint height,
        string description, List<Color> colors, string materials, string pathToImage, string pathToImageSchema)
    {
        return new Facade(id, name, shortName, length, width, height, description, colors, materials, pathToImage,
            pathToImageSchema);
    }
}