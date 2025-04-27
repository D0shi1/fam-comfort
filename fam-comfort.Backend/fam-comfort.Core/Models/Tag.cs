namespace fam_comfort.Core.Models;

public class Tag
{
    private Tag(Guid id, string name, List<Guid> productIds)
    {
        Id = id;
        Name = name;
        ProductIds = productIds;
    }

    public Tag()
    {
    }    
    
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public List<Product> Products { get; set; }

    public List<Guid> ProductIds { get; set; } = [];

    public static Tag Create(Guid id, string name, List<Guid> productIds)
    {
        return new Tag(id, name, productIds);
    }
}