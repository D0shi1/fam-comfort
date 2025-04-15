namespace fam_comfort.Core.Models;

public class Color
{
    private Color(Guid id, Guid facadeId, string name, string pathToImage)
    {
        PathToImage = pathToImage;
        FacadeId = facadeId;
        Id = id;
        Name = name;
    }

    public Color()
    {
    }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PathToImage { get; set; }
    public Facade Facade { get; set; }
    public Guid FacadeId { get; set; }

    public static Color Create(Guid id, string name, string pathToImage, Guid facadeId)
    {
        return new Color(id, facadeId, name, pathToImage);
    }
}