using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CampaignDesignerBE.Models;

namespace CampaignDesignerBE.Data
{
  public class CampaignDesignerContext : DbContext
  {
    public DbSet<Campaign> Campaigns {get;set;}
    public DbSet<PlotPoint> PlotPoints {get;set;}
    public DbSet<Transition> Transitions {get;set;}
    

    public CampaignDesignerContext(DbContextOptions<CampaignDesignerContext> options) : base(options)
    {

    }

  }

}
