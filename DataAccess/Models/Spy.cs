namespace DataAccess.Models;

public class Spy
{
    public Guid Id { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? SecondName { get; set; }
    
    public string? Alias{get;set;}
    
    public DateTime? DateOfBirth { get; set; }
    
    public string? Nationality { get; set; }
}

