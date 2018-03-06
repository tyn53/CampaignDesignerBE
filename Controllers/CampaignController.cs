using Microsoft.AspNetCore.Mvc;
using CampaignDesignerBE.Models;
using CampaignDesignerBE.Repositories;
using Newtonsoft.Json;

[Route("[controller]")]
public class CampaignController : Controller
{
  private readonly ICampaignRepository _campaignRepository;
  public CampaignController(ICampaignRepository campaignRepository)
  {
    _campaignRepository = campaignRepository;
  }

  // GET: /Campaigns/
  [HttpGet]
  public string Campaigns()
  {
    var campaigns = _campaignRepository.ListAll();
    return JsonConvert.SerializeObject(campaigns);
  }
}
