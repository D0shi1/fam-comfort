namespace fam_comfort.Core.Models;

public class Product
{
    private Product(Guid id, string name,  string shortName, ushort length, ushort width, ushort height,
        string description, string materials, string pathToImageSchema, Guid categoryId)
    {
        Id = id;
        Name = name;
        ShortName = shortName;
        Length = length;
        Width = width;
        Height = height;
        Description = description;
        Materials = materials;
        PathToImageSchema = pathToImageSchema;
        CategoryId = categoryId;
    }

    public Product()
    {
    }

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public ushort Length { get; set; }
    public ushort Width { get; set; }
    public ushort Height { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Materials { get; set; } = string.Empty;
    public string PathToImageSchema { get; set; } = string.Empty;
    public List<Color> Colors { get; set; } = [];
    public Category Category { get; set; }
    public Guid CategoryId { get; set; }

    public static Product Create(Guid id, string name, string shortName, ushort length, ushort width, ushort height,
        string description, string materials, string pathToImageSchema, Guid categoryId)
    {
        return new Product(id, name, shortName, length, width, height, description, materials, pathToImageSchema,categoryId);
    }
}