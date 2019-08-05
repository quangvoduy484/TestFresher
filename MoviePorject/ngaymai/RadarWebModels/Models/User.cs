using System;
using System.Collections.Generic;
using System.Text;

namespace RadarWebModels.Models
{
  public class User:BaseEntity
  {
    public bool Live { get; set; }
    public string UserId { get; set; }
    public string DeviceId { get; set; }
    public string Description { get; set; }
    public string LocationType { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string ExternalId { get; set; }     
    public DateTime UpdatedAt { get; set; }
    public string DeviceType { get; set; }
    public double LocationAccuracy { get; set; }
    public bool Stopped { get; set; }
    public bool Foreground { get; set; }
    public string Ip { get; set; }

  }
}
