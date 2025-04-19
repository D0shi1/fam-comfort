namespace fam_comfort.Core.Models;

public class Tag
{
    private Tag(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Tag()
    {
    }    
    
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;

    public List<Guid?> ProductIds { get; set; } = [];

    public static Tag Create(Guid id, string name)
    {
        return new Tag(id, name);
    }
}