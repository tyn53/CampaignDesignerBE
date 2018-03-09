using System;
using System.Collections.Generic;
using System.Linq;

namespace CampaignDesignerBE.Models
{
  public class Transition
  {
    public int TransitionID {get;set;}
    public string TransitionSummary {get;set;}
    public EntityType EntityType {get;set;}
    public int InputID {get;set;}
    public int OutputID {get;set;}
  }
}
