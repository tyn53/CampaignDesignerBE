using CampaignDesignerBE.Models;
using CampaignDesignerBE.Data;
using System;
using System.Linq;

namespace CampaignDesignerBE.Data
{
  public static class DbInitializer
  {
    public static void Initialize(CampaignDesignerContext context)
    {
      context.Database.EnsureCreated();

      if(context.Campaigns.Any())
      {
        return;
      }

      var campaigns = new Campaign[]
      {
        new Campaign{CampaignName="Aardmor"},
        new Campaign{CampaignName="The Shadow Lands"},
        new Campaign{CampaignName="The Maker's Passing"}
      };

      foreach ( var campaign in campaigns)
      {
        context.Campaigns.Add(campaign);
      }
      context.SaveChanges();
    }
  }
}
