using CampaignDesignerBE.Models;
using System.Collections.Generic;



namespace CampaignDesignerBE.Repositories
{
  public interface ICampaignRepository
  {
    IEnumerable<Campaign> ListAll();
    Campaign GetById(int campaignId);
    bool Add(Campaign campaign);
  }
}
