namespace Portfolio.Dashboard.Get.DTOs;

public class GetCompanyDto
{
    public int Id { get; init; }
    
    public string Url { get; init; } = null!;
    public string Name { get; init; } = null!;
    public string Location { get; init; } = null!;
}