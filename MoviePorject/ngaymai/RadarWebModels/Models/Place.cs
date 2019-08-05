using System;
using System.Collections.Generic;
using System.Text;

namespace RadarWebModels.Models
{
  class Place
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string ChainName { get; set; }
    public string ChainSlug { get; set; }
    public string ChainDomain { get; set; }
    public string Categories { get; set; }
    public string LoactionType { get; set; }
    public string LoacationCoordinates { get; set; }
  }
}
