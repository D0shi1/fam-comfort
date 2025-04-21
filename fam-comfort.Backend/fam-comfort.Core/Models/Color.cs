namespace fam_comfort.Core.Models;

public class Color
{
    private Color(Guid id, Guid productId, string name, string pathToImage)
    {
        PathToImage = pathToImage;
        ProductId = productId;
        Id = id;
        Name = name;
    }

    public Color()
    {
    }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PathToImage { get; set; }
    public Product Product { get; set; }
    public Guid ProductId { get; set; }

    public static Color Create(Guid id, string name, string pathToImage, Guid productId)
    {
        return new Color(id, productId, name, pathToImage);
    }
}