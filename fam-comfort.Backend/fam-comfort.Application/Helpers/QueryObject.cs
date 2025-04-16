namespace fam_comfort.Application.Helpers;

public class QueryObject
{
    public string? Name { get; set; }
    public string? SortBy { get; set; }
    public bool IsDescending { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}