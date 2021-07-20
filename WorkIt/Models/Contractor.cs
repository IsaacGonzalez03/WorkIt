using System;

namespace WorkIt.Models
{
  public class Contractor
  {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string AccountId { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
    public Profile Profile { get; set; }
  }
}