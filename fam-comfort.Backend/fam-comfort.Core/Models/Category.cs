namespace fam_comfort.Core.Models;

public class Category
{
    public  Guid Id { get; set; }
    public string Name { get; set; }
    public string PathToImage { get; set; }
    public List<Product> Products { get; set; }
    public Catalog Catalog { get; set; }
    public Guid CatalogId { get; set; }
}