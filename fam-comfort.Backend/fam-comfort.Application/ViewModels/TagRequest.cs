using fam_comfort.Core.Models;

namespace fam_comfort.Application.ViewModels;

public class TagRequest
{
    public string Name { get; set; } = string.Empty;
    public List<Guid?> ProductIds { get; set; } = [];
}