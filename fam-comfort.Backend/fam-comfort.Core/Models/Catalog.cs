namespace fam_comfort.Core.Models;

public class Catalog
{
    public  Guid Id { get; set; }
    public string Name { get; set; }
    public string PathToImage { get; set; }
    public List<Category> Categories { get; set; }
}