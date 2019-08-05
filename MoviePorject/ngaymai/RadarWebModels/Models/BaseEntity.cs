using System;
using System.Collections.Generic;
using System.Text;

namespace RadarWebModels.Models
{
  public class BaseEntity
  {
    public string Id { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
  }
}
