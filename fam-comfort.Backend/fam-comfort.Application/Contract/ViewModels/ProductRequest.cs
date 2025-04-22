using fam_comfort.Application.Contract.Dto;

namespace fam_comfort.Application.Contract.ViewModels;

public class ProductRequest
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public ushort Length { get; set; }
    public ushort Width { get; set; }
    public ushort Height { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Materials { get; set; } = string.Empty;
    public string PathToImageSchema { get; set; } = string.Empty;
    public List<CreateColorRequest> Colors { get; set; } = [];
    public Guid? TagId { get; set; } = null;
}