namespace fam_comfort.Application.Contract.Dto;

public class ColorDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PathToImage { get; set; } = string.Empty;
}