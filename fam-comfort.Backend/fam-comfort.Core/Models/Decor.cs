namespace fam_comfort.Core.Models;

public class Decor : BuildingElement
{
    private Decor(Guid id, string name, string shortName, ushort length, ushort width, ushort height,
        string description, string materials, string pathToImageSchema, Guid decorCategoryId)
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
        DecorCategoryId = decorCategoryId;
    }

    public Decor()
    {
    }

    public Guid Id { get; set; }
    public Guid DecorCategoryId { get; set; }
    public DecorCategory DecorCategory { get; set; }

    public static Decor? Create(Guid id, string name, string shortName, ushort length, ushort width, ushort height,
        string description, string materials, string pathToImageSchema, Guid facadeCategoryId)
    {
        return new Decor(id, name, shortName, length, width, height, description, materials,
            pathToImageSchema, facadeCategoryId);
    }
}