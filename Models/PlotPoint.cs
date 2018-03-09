using System;
using System.Collections.Generic;
using System.Linq;

namespace CampaignDesignerBE.Models
{
  public class PlotPoint
  {
    public int PlotPointID {get;set;}
    public string PlotPointDesc {get;set;}

    public int CampaignID {get;set;}
    public IEnumerable<Transition> Transitions {get; set;}

    public bool isRoot {get;set;}
  }
}
