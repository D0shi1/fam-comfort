namespace fam_comfort.Core.Models;

public class Category
{
    private Category(Guid id, string name, string pathToImage, Guid catalogId)
    {
        Id = id;
        Name = name;
        PathToImage = pathToImage;
        CatalogId = catalogId;
    }

    public Category()
    {

    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PathToImage { get; set; }
    public List<Product> Products { get; set; }
    public Catalog Catalog { get; set; }
    public Guid CatalogId { get; set; }

    public static Category Create(Guid id, string name, string pathToImage, Guid catalogId)
    {
        return new Category(id, name, pathToImage, catalogId);
    }

}