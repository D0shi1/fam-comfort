namespace fam_comfort.Core.Models;

public class Color(Guid id, string name, string hexColor)
{
    public Guid Id { get; set; } = id;

    public string Name { get; set; } = name;

    public string HexColor { get; set; } = hexColor;
    
    public List<Facade> Facades { get; set; } = [];
}