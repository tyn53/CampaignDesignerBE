using System;
using Microsoft.AspNetCore.Mvc;
using CampaignDesignerBE.Models;
using CampaignDesignerBE.Repositories;
using Newtonsoft.Json;

public class CampaignController : Controller
{
  private readonly ICampaignRepository _campaignRepository;
  public CampaignController(ICampaignRepository campaignRepository)
  {
    _campaignRepository = campaignRepository;
  }

  // GET: /Campaigns/
  [Route("campaigns")]
  [HttpGet]
  public string Campaigns()
  {
    var campaigns = _campaignRepository.ListAll();
    return JsonConvert.SerializeObject(campaigns);
  }

  [Route("campaigns/{campaignId}")]
  [HttpGet]
  public string Campaign(int campaignId)
  {
    var campaign = _campaignRepository.GetById(campaignId);
    return JsonConvert.SerializeObject(campaign);
  }

  [Route("campaigns/")]
  [HttpPost]
  public bool Add([FromBody] Campaign campaign)
  {
    return _campaignRepository.Add(campaign);
  }
}
