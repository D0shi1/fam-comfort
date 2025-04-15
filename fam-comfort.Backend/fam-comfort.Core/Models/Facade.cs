namespace fam_comfort.Core.Models;

public class Facade : Object
{
    private Facade(Guid id, string name, string shortName, ushort length, ushort width, ushort height,
        string description, string materials, string pathToImageSchema, Guid facadeCategoryId)
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
        FacadeCategoryId = facadeCategoryId;
    }

    public Facade()
    {
    }

    public Guid Id { get; set; }
    public List<Color> Colors { get; set; } = [];
    public Guid FacadeCategoryId { get; set; }

    public FacadeCategory FacadeCategory { get; set; }

    public static Facade? Create(Guid id, string name, string shortName, ushort length, ushort width, ushort height,
        string description, string materials, string pathToImageSchema, Guid facadeCategoryId)
    {
        return new Facade(id, name, shortName, length, width, height, description, materials,
            pathToImageSchema, facadeCategoryId);
    }
}