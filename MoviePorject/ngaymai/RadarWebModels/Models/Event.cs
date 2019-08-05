using System;
using System.Collections.Generic;
using System.Text;

namespace RadarWebModels.Models
{
  public class Event:BaseEntity
  {
    public bool Live { get; set; }
    public DateTime CreateAt { get; set; }
    public string Type { get; set; }
    public string UserId { get; set; }
    public string GeofenceId { get; set; }
    public string LocationType { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double LoactionAccurary { get; set; }
    public double Confidence { get; set; }
    public double Duration { get; set; }
    public double Verification { get; set; }
  }
}
