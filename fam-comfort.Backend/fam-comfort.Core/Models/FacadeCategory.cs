namespace fam_comfort.Core.Models;

public class FacadeCategory
{
    private FacadeCategory(Guid id, string name, string pathToImage)
    {
        Id = id;
        Name = name;
        PathToImage = pathToImage;
    }

    public FacadeCategory()
    {
    }
    
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string PathToImage { get; set; } = string.Empty;
    
    public List<Facade> Facades { get; set; } = [];

    public static FacadeCategory Create(Guid id, string name, string pathToImage)
    {
        return new FacadeCategory(id, name, pathToImage);
    }
}