namespace fam_comfort.Core.Models;

public class DecorCategory
{
    private DecorCategory(Guid id, string name, string pathToImage)
    {
        Id = id;
        Name = name;
        PathToImage = pathToImage;
    }

    public DecorCategory()
    {
    }
    
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string PathToImage { get; set; } = string.Empty;
    
    public List<Decor> Decors { get; set; } = [];

    public static DecorCategory? Create(Guid id, string name, string pathToImage)
    {
        return new DecorCategory(id, name, pathToImage);
    }
}