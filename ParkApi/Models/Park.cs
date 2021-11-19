using System.ComponentModel.DataAnnotations;

namespace ParkApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string State { get; set; }
    [Range(0, 10, ErrorMessage="Rating must be between 0 and 10.")]
    public int Rating { get; set; }
  }
}