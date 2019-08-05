using System;
using System.Collections.Generic;
using System.Text;

namespace RadarWebModels.Models
{

  public class EventPosition
  {
    public EventModel[] events { get; set; }
    public EventModel @event { get; set; }
    public UserModel user { get; set; }


  }
  public class LocationModel
    {
      public string type { get; set; }
      public double[] coordinates { get; set; }
    }

    public class Geometry
    {
      public string type { get; set; }
      public List<double[]> coordinates { get; set; }
    }
    public class GeomeTryCenter
    {
      public string type { get; set; }
      public double[] coordinates { get; set; }

    }

    public class Geofence
    {
      public string _id { get; set; }
      public string tag { get; set; }
      public string type { get; set; }
      public DateTime createdAt { get; set; }
      public bool live { get; set; }
      public string externalId { get; set; }
      public string description { get; set; }
      public GeomeTryCenter geometryCenter { get; set; }
      public double geometryRadius { get; set; }
      public Dictionary<string, object> metadata { get; set; }

      public string UserId { get; set; }
      public bool enabled { get; set; }
    }
    public class Insight
    {
      public class State
      {
        public bool home { get; set; }
        public bool office { get; set; }
        public bool traveling { get; set; }
      }
      public State state { get; set; }
      public class LoactionInsight
      {
        public string Type { get; set; }
        public double[] coordinates { get; set; }
        public double confidence { get; set; }

      }
      public LoactionInsight locations { get; set; }
    }

    public class Place1
    {
      public string _id { get; set; }
      public string name { get; set; }
      public Chain chain { get; set; }
      public class Chain
      {
        public string name { get; set; }
        public string slug { get; set; }
        public string domain { get; set; }

      }
      public string[] categories { get; set; }
      public LocationModel Location { get; set; }
    }

    
    public class EventModel
    {

      public string _id { get; set; }
      public DateTime createdAt { get; set; }
      public bool live { get; set; }
      public string type { get; set; }
      public LocationModel location { get; set; }
      public Geofence geofence { get; set; }
      //public Place1 place { get; set; }

      public double locationAccuracy { get; set; }
      public double confidence { get; set; }
      public double duration { get; set; }
      public double verification { get; set; }
    }
    public class UserModel
    {
      public string _id { get; set; }
      public string userId { get; set; }
      public string description { get; set; }
      public string externalId { get; set; }
      public bool live { get; set; }
      public string deviceId { get; set; }
      public LocationModel Location { get; set; }
      public Dictionary<string, object> metadata { get; set; }
      public DateTime updatedAt { get; set; }
      public string deviceType { get; set; }
      public double locationAccuracy { get; set; }
      public bool stopped { get; set; }
      public bool foreground { get; set; }
      public string ip { get; set; }
      //public Insight insights  { get; set; }

    }
  
}
