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
              new Park { ParkId = 1, Name = "Big Bend", Type = "National", City = "Terlingua", State = "Texas", Rating = 10},
              new Park { ParkId = 2, Name = "Big Bend", Type = "State", City = "Presidio", State = "Texas", Rating = 9},
              new Park { ParkId = 3, Name = "Crater Lake", Type = "National", City = "Klamath Falls", State = "Oregon", Rating = 9},
              new Park { ParkId = 4, Name = "Petrified Forest", Type = "National", City = "Sun Valley", State = "Arizona", Rating = 7},
              new Park { ParkId = 5, Name = "Dead Horse Point", Type = "State", City = "Moab", State = "Utah", Rating = 7}
          );
    }

    public DbSet<Park> Parks { get; set; }
  }
}