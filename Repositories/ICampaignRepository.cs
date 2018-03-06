using CampaignDesignerBE.Models;
using System.Collections.Generic;



namespace CampaignDesignerBE.Repositories
{
  public interface ICampaignRepository
  {
    IEnumerable<Campaign> ListAll();
    void Add(Campaign campaign);
  }
}
