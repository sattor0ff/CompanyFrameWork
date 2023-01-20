namespace Domain.Dtos;

public class CompanyDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public CompanyDto()
    {
        
    }
     public CompanyDto(int id, string? name)
    {
        Id = id;
        Name = name;
    }
    
}