namespace fam_comfort.Core.Models;

public class BuildingElement
{
    public string Name { get; set; } = string.Empty;

    public string ShortName { get; set; } = string.Empty;

    public ushort Length { get; set; }

    public ushort Width { get; set; }

    public ushort Height { get; set; }

    public string Description { get; set; } = string.Empty;
    public string Materials { get; set; } = string.Empty;
    public string PathToImageSchema { get; set; } = string.Empty;
}