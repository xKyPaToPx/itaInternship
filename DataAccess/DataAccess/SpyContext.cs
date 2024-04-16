using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace pisLab1;

public class SpyContext: DbContext
{
    public static DbContextOptions<SpyContext> Options { get; set; }
    public DbSet<Spy> Spies => Set<Spy>();
    public DbSet<Equipment> Equipments => Set<Equipment>();
    public DbSet<Mission> Missions => Set<Mission>();

    public SpyContext() : base(Options)
    {
        
    }
    
        
   
    
}