namespace fam_comfort.Core.Models;

public class Catalog
{
    private Catalog(Guid id, string name, string pathToImage)
    {
        Id = id;
        Name = name;
        PathToImage = pathToImage;
    }

    public Catalog()
    {
        
    }
    public  Guid Id { get; set; }
    public string Name { get; set; }
    public string PathToImage { get; set; }
    public List<Category> Categories { get; set; }

    public static Catalog Create(Guid id, string name, string pathToImage)
    {
        return new Catalog { Id = id, Name = name, PathToImage = pathToImage };
    }
}