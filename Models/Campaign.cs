using Microsoft.EntityFrameworkCore;

namespace CampaignDesignerBE.Models
{
  public class Campaign
  {
    public int CampaignID { get; set; }
    public string CampaignName { get; set; }
  }
}
