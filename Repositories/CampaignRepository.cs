using System;
using System.Collections.Generic;
using System.Linq;
using CampaignDesignerBE.Data;
using CampaignDesignerBE.Models;

namespace CampaignDesignerBE.Repositories
{
  public class CampaignRepository : ICampaignRepository
  {
    private readonly CampaignDesignerContext _dbContext;

    public CampaignRepository(CampaignDesignerContext dbContext)
    {
      _dbContext = dbContext;
    }

    public IEnumerable<Campaign> ListAll()
    {
      return _dbContext.Campaigns.AsEnumerable();
    }

    public Campaign GetById(int campaignId)
    {
      return _dbContext.Campaigns.Where(camp => camp.CampaignID == campaignId).SingleOrDefault();
    }

    public bool Add(Campaign campaign)
    {
      try{
        _dbContext.Campaigns.Add(campaign);
        _dbContext.SaveChanges();
        return true;
      } catch (Exception ex) {
        //TODO: Figure out logging;
      }
      return false;
    }
  }
}
