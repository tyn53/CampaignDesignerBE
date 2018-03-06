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

    public void Add(Campaign campaign)
    {
      _dbContext.Campaigns.Add(campaign);
      _dbContext.SaveChanges();
    }
  }
}
