using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
  public class ParkApiContext : DbContext
  {
    public ParkApiContext(DbContextOptions<ParkApiContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 1, Name = "Big Bend", Type = "State", State = "Texas", Rating = 8},
              new Park { ParkId = 2, Name = "Big Bend", Type = "National", State = "Texas", Rating = 10},
              new Park { ParkId = 3, Name = "Crater Lake", Type = "National", State = "Oregon", Rating = 10},
              new Park { ParkId = 4, Name = "Bastrop", Type = "State", State = "Texas", Rating = 5},
              new Park { ParkId = 5, Name = "Dead Horse Point", Type = "State", State = "Utah", Rating = 7}
          );
    }

    public DbSet<Park> Parks { get; set; }
  }
}