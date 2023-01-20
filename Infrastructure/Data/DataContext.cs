using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    
      
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Company>().HasData(
            new List<Company>()
            {
                new Company(1, "Lexus"),
                new Company(2, "Mercedes"),
                new Company(3, "Audi"),
                new Company(4, "Bmw"),
            });

        modelBuilder.Entity<User>().HasData(
            new List<User>()
            {
                new User(1, "Ardasher", 3),
                new User(2, "Abdullah", 1),
                new User(3, "Anushervon", 2),
                new User(4, "Sherzod", 2),
                new User(5, "Muhammad", 3),
            }
        );
        
        base.OnModelCreating(modelBuilder);

    }
}