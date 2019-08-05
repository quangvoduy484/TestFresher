using System;
using System.Collections.Generic;
using System.Text;

namespace RadarWebModels.Models
{
  public class Geofences:BaseEntity
  {
    public bool Live { get; set; }
    public DateTime CreateAt { get; set; }
    public string Tag { get; set; }
    public string ExternalId { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public string GeometryCenterType { get; set; }
    public double GeometryCenterLatitude { get; set; }
    public double GeometryCenterLongitude { get; set; }
    public double GeometryRadius { get; set; }
    public string UserId { get; set; }// user id
    public bool? Enabled { get; set; }
  }
}
