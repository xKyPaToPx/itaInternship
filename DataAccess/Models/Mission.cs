namespace DataAccess.Models;

public class Mission
{
    public Guid Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    public Spy SpyId { get; set; }
}