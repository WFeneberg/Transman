using Microsoft.EntityFrameworkCore;

namespace Transman.Persons;

public class PersonDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Persons.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //Configure the relations
      
        
        //Configure additional columns
       
    }
}