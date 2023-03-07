using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bridge.ERP;
using Bridge.ERP.Models;
using Bridge.ERP.Data;
using System.Globalization;
using Newtonsoft.Json;
using System.Text.Json;
using Bridge.ERP.Helpers;

namespace Bridge.ERP.Controllers
{
    public class ProviderHistoryCallsController : Controller
    {
        private readonly bidbdesenvContext _context;

        public ProviderHistoryCallsController(bidbdesenvContext context)
        {
            _context = context;
        }

        [HttpPost]
        public string Index(string rangeDate, IEnumerable<string> campaigns, int i)
        {
            return "Teste post filter ";

        }
        [HttpGet]
        public IActionResult IndexStart(string rangeDate, IEnumerable<string> campaigns)
        {
            // Get Campaigns
            var c = _context
                .Campaigns
                .Where(c => c
                .TenantId == 1 && c
                .ThirdPartyCampaignId != null
                ).ToList();
            var campaign = from camp in c
                           select new
                           {
                               id = camp.ThirdPartyCampaignId,
                               text = camp.Name
                           };
            ViewBag.Campaigns = campaign;

            return View("Index");

        }
        //Old INDEX method
        //[HttpGet]
        //public async Task<IActionResult> Index(string rangeDate, IEnumerable<string> campaigns, string t)
        //{
        //    // temporary code
        //    var trangeDate = "2021-11-02_2021-11-03".ToString();
        //    var convRangeDate = rangeDate;
        //    // end temporary code
        //    DateTime startTime = DateTime.Now;
        //    var startDate = "";
        //    var endDate = "";
        //    if (convRangeDate != null)
        //    {
        //        startDate = Convert.ToDateTime(convRangeDate.Split("_")[0]).ToString();
        //        endDate = Convert.ToDateTime(convRangeDate.Split("_")[1]).ToString();
        //    }
        //    else
        //    {
        //        startDate = DateTime.Today.AddDays(-3).ToString();
        //        endDate = DateTime.Today.AddDays(1).ToString();

        //    }

        //    if (campaigns.Count() == 0)
        //    {

        //    }

        //    //Get all calls from a requested range
        //    DateTime start = Convert.ToDateTime(startDate);
        //    DateTime end = Convert.ToDateTime(endDate);
        //    var datasetCalls = _context.ProviderHistoryCalls
        //        .Where(a => a
        //        .CallStartDate >= start && a
        //        .CallStartDate <= end && a
        //        .CampaignName == "Cashbuyers - CT" || a
        //        .CampaignName == "Cashbuyers - MA")
        //        .ToList();

        //    //Total Leads - Hot and Warm
        //    var totalLeads = datasetCalls
        //        .Where(a => a
        //        .CallDisposition.ToLower() is "cashbuyer" || a
        //        .CallDisposition.ToLower() is "cashbuyer")
        //        .GroupBy(d => new
        //        {
        //            leadType = d.CallDisposition.ToLower(),
        //        }
        //        ).Select(g => new { lead = $"{g.Key.leadType}", count = g.Count() })
        //        .ToDictionary(k => k.lead, i => i.count);
        //    var sumLeads = totalLeads.Values.Sum();

        //    // Get All Connected Calls From Dataset
        //    var callsConnectedFromDataset = datasetCalls
        //        .Where(a => a
        //        .CallStartDate >= start && a
        //        .CallStartDate <= end && (a
        //        .SystemDisposition == "Answered" || a
        //        .SystemDisposition == "Answered Human Abandoned" || a
        //        .SystemDisposition == "Answered Human Agentconnect" || a
        //        .SystemDisposition == "Answered Machine" || a
        //        .SystemDisposition == "Answered Machine Abandoned" || a
        //        .SystemDisposition == "Answered Machine Agentconnect" || a
        //        .SystemDisposition == "Answered Notsure" || a
        //        .SystemDisposition == "Answered Notsure Abandoned" || a
        //        .SystemDisposition == "Answered Notsure Agentconnect")
        //        )
        //        .GroupBy(d => new
        //        {
        //            adjYear = d.CallStartDate.Date.Year,
        //            adjMonth = d.CallStartDate.Date.Month,
        //            ajdDay = d.CallStartDate.Date.Day,
        //        }
        //        ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
        //        .ToDictionary(k => k.date, i => i.count);

        //    // Get All Connected Considered for Abandoned Rate
        //    var callsConsideredForAbandonedFromDataset = datasetCalls
        //        .Where(a => a
        //        .CallStartDate >= start && a
        //        .CallStartDate <= end && (a
        //        .SystemDisposition == "Answered Human Abandoned" || a
        //        .SystemDisposition == "Answered Human Agentconnect" || a
        //        .SystemDisposition == "Answered Machine" || a
        //        .SystemDisposition == "Answered Machine Abandoned" || a
        //        .SystemDisposition == "Answered Machine Agentconnect" || a
        //        .SystemDisposition == "Answered Notsure" || a
        //        .SystemDisposition == "Answered Notsure Abandoned" || a
        //        .SystemDisposition == "Answered Notsure Agentconnect")
        //        )
        //        .GroupBy(d => new
        //        {
        //            adjYear = d.CallStartDate.Date.Year,
        //            adjMonth = d.CallStartDate.Date.Month,
        //            ajdDay = d.CallStartDate.Date.Day,
        //        }
        //        ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
        //        .ToDictionary(k => k.date, i => i.count);


        //    // Get All Connected Calls From Dataset
        //    var callsHumanConnectedFromDatasetNormalized = datasetCalls
        //        .Where(a => a
        //        .CallStartDate >= start && a
        //        .CallStartDate <= end && (a
        //        .SystemDisposition == "Answered Human Agentconnect" || a
        //        .SystemDisposition == "Answered Machine Agentconnect" || a
        //        .SystemDisposition == "Answered Notsure Agentconnect")
        //        )
        //        .GroupBy(d => new
        //        {
        //            adjYear = d.CallStartDate.Date.Year,
        //            adjMonth = d.CallStartDate.Date.Month,
        //            ajdDay = d.CallStartDate.Date.Day,
        //        }
        //        ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
        //        .ToDictionary(k => k.date, i => i.count);

        //    // Get All Connected Calls From Dataset
        //    var callsTotalAbandonedFromDataset = datasetCalls
        //        .Where(a => a
        //        .CallStartDate >= start && a
        //        .CallStartDate <= end && (a
        //        .SystemDisposition == "Answered Human Abandoned" || a
        //        .SystemDisposition == "Answered Machine Abandoned" || a
        //        .SystemDisposition == "Answered Notsure Abandoned")
        //        )
        //        .GroupBy(d => new
        //        {
        //            adjYear = d.CallStartDate.Date.Year,
        //            adjMonth = d.CallStartDate.Date.Month,
        //            ajdDay = d.CallStartDate.Date.Day,
        //        }
        //        ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
        //        .ToDictionary(k => k.date, i => i.count);

        //    // Get All Connected Calls From Dataset
        //    var callsHumanAbandonedFromDataset = datasetCalls
        //        .Where(a => a
        //        .CallStartDate >= start && a
        //        .CallStartDate <= end && (a
        //        .SystemDisposition == "Answered Human Abandoned" || a
        //        .SystemDisposition == "Answered Notsure Abandoned")
        //        )
        //        .GroupBy(d => new
        //        {
        //            adjYear = d.CallStartDate.Date.Year,
        //            adjMonth = d.CallStartDate.Date.Month,
        //            ajdDay = d.CallStartDate.Date.Day,
        //        }
        //        ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
        //        .ToDictionary(k => k.date, i => i.count);

        //    // Charts 

        //    //Group by Date from dataset
        //    var callsByDateFromDataset = datasetCalls
        //        .Where(a => a
        //        .CallStartDate >= start && a
        //        .CallStartDate <= end)
        //        .GroupBy(d => new
        //        {
        //            adjYear = d.CallStartDate.Date.Year,
        //            adjMonth = d.CallStartDate.Date.Month,
        //            ajdDay = d.CallStartDate.Date.Day,
        //            // adjYear = EF.Property<DateTime>(d, "CallStartDate").Date.Year,
        //            // adjMonth = EF.Property<DateTime>(d, "CallStartDate").Date.Month,
        //            // ajdDay = EF.Property<DateTime>(d, "CallStartDate").Date.Day,
        //        }
        //        ).Select(
        //        g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
        //        .ToDictionary(k => k.date, i => i.count);

        //    // Total Talked Time
        //    var totalTalkedTimeFromDataset = datasetCalls
        //        .Where(a => a
        //        .CallStartDate >= start && a
        //        .CallStartDate <= end && a
        //        .SystemDisposition == "Answered Human Agentconnect" || a
        //        .SystemDisposition == "Answered Machine Agentconnect" || a
        //        .SystemDisposition == "Answered Notsure Agentconnect").ToList();

        //    //System disposition
        //    var callsSystemDispositionFromDataset = datasetCalls
        //        .GroupBy(d => new
        //        {
        //            systemDispo = d.SystemDisposition.ToLower(),
        //        }
        //        )
        //        .Select(g => new { systemDisposition = $"{g.Key.systemDispo}", count = g.Count() })
        //        .OrderByDescending(o => o.count)
        //        .ToDictionary(k => k.systemDisposition, i => i.count);

        //    //Call disposition
        //    var callsDispositionFromDataset = datasetCalls
        //        .Where(c => c.CallDisposition != null && c.CallDisposition != String.Empty)
        //        .GroupBy(d => new
        //        {
        //            callDispo = d.CallDisposition.ToLower(),
        //        }
        //        )
        //        .Select(g => new { callDisposition = $"{g.Key.callDispo}", count = g.Count() })
        //        .OrderByDescending(o => o.count)
        //        .ToDictionary(k => k.callDisposition, i => i.count);

        //    ViewBag.TotalCallsByDate = callsByDateFromDataset;
        //    ViewBag.TotalConnectedCallsByDate = callsConnectedFromDataset;     
        //    ViewBag.TotalConnectedToAgent = callsHumanConnectedFromDatasetNormalized;
        //    ViewBag.ConnectionRate = Helpers.MathOperations.DivisionReturnPercentage(callsConnectedFromDataset.Values.Sum(), callsByDateFromDataset.Values.Sum());
        //    ViewBag.ConnectionAgentRate = Helpers.MathOperations.DivisionReturnPercentage(callsHumanConnectedFromDatasetNormalized.Values.Sum(),callsByDateFromDataset.Values.Sum());
        //    ViewBag.ConvertionRate = Helpers.MathOperations.DivisionReturnPercentage(sumLeads, callsHumanConnectedFromDatasetNormalized.Values.Sum());
        //    ViewBag.DropRate = Helpers.MathOperations.DivisionReturnPercentage(callsTotalAbandonedFromDataset.Values.Sum(), callsConsideredForAbandonedFromDataset.Values.Sum());
        //    ViewBag.LeadsCount = totalLeads;
        //    ViewBag.TotalTalkedTime = Math.Round((decimal)totalTalkedTimeFromDataset.Sum(t => t.CallDuration) / 60 ) /60;
        //    if (ViewBag.TotalTalkedTime > 0) ViewBag.AverageTalkedTime = Math.Round((double)(totalTalkedTimeFromDataset.Average(t => t.CallDuration))) / 60;
        //    ViewBag.AgentDropRate = Helpers.MathOperations.DivisionReturnPercentage(callsHumanAbandonedFromDataset.Values.Sum(), callsConsideredForAbandonedFromDataset.Values.Sum());
        //    if(callsConnectedFromDataset.Values.Sum() > 0) ViewBag.CallToGetLead = callsConnectedFromDataset.Values.Sum() / totalLeads.Values.Sum();
        //    ViewBag.CallsSystemDispositions = callsSystemDispositionFromDataset;
        //    ViewBag.CallsDisposition = callsDispositionFromDataset;

        //    var endTime = DateTime.Now;
        //    var resultTime = endTime - startTime;
        //    var toJsonResult = Json(datasetCalls);
        //    return PartialView("Index", ViewBag);
        //}

        public async Task<IActionResult> GetCampaignsList()
        {
            SelectList campaigns = new SelectList(_context
                .ProviderHistoryCalls
                .Where(c => c.CampaignName != "").ToList(), "campaignId", "campaignName");
            ViewBag.Campaigns = campaigns;
            return View(campaigns);
        }

        public async Task<IActionResult> Index(string rangeDate, IEnumerable<string> campaigns, string t)
        {
            try
            {     
                var convRangeDate = rangeDate;
         
                DateTime startTime = DateTime.Now;

                var startDate = "";
                var endDate = "";
                if (convRangeDate != null)
                {
                    startDate = Convert.ToDateTime(convRangeDate.Split("_")[0]).ToString();
                    endDate = Convert.ToDateTime(convRangeDate.Split("_")[1]).ToString();
                }
                else
                {
                    startDate = DateTime.Today.AddDays(-6).ToString();
                    endDate = DateTime.Today.AddDays(1).ToString();

                }
                //Get all calls from a requested range
                DateTime startConv = Convert.ToDateTime(startDate);
                DateTime endConv = Convert.ToDateTime(endDate);
                DateTime start = startConv.AddHours(00).AddMinutes(00).AddSeconds(00);
                DateTime end = endConv.AddDays(1).AddSeconds(-1);

                //var rawQuery = db.Database.ExecuteSqlRaw("Select * from ProviderHistoryCalls where Id < 10");

                var datasetCalls = await _context.ProviderHistoryCalls
                    .Where(a => a
                    .TenantId == 1 && a
                    .CallStartDate >= start && a
                    .CallStartDate <= end) 
                    .OrderBy(a => a.CallStartDate)
                    .ToListAsync();

                // ***************  FILTER CAMPAIGNS *********************
                var filterCampaigns = campaigns.FirstOrDefault();

                if (filterCampaigns != "All" && filterCampaigns != null)
                {
                    datasetCalls = datasetCalls.Where(w => campaigns.Contains(w.CampaignId)).ToList();
                }

                // ***************  FILTER DISPOSITIONS *********************
                if (true)
                {
                    // PENDING TO DO: FILTER DISPOSITIONS
                }

                //Total Leads - Hot and Warm
                var totalLeads = datasetCalls
                    .Where(a => a
                    .CallDisposition.ToLower() == "hot lead" || a
                    .CallDisposition.ToLower() == "warm lead")
                    .GroupBy(d => new
                    {
                        leadType = d.CallDisposition.ToLower(),
                    }
                    ).Select(g => new { lead = $"{g.Key.leadType}", count = g.Count() })
                    .ToDictionary(k => k.lead, i => i.count);
                var sumLeads = totalLeads.Values.Sum();

                //Group by Date from dataset
                var callsByDateFromDataset = datasetCalls
                    .Where(a => a
                    .CallStartDate >= start && a
                    .CallStartDate <= end)
                    .GroupBy(d => new
                    {
                        adjYear = d.CallStartDate.Date.Year,
                        adjMonth = d.CallStartDate.Date.Month,
                        ajdDay = d.CallStartDate.Date.Day,
                        // adjYear = EF.Property<DateTime>(d, "CallStartDate").Date.Year,
                        // adjMonth = EF.Property<DateTime>(d, "CallStartDate").Date.Month,
                        // ajdDay = EF.Property<DateTime>(d, "CallStartDate").Date.Day,
                    }
                    ).Select(
                    g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
                    .ToDictionary(k => k.date, i => i.count);

                //Used in Charts
                // Get All Connected Calls From Dataset
                var callsConnectedFromDataset = datasetCalls
                    .Where(a => a
                    .CallStartDate >= start && a
                    .CallStartDate <= end && (a
                    .SystemDisposition == "Answered" || a
                    .SystemDisposition == "Answered Human Abandoned" || a
                    .SystemDisposition == "Answered Human Agentconnect" || a
                    .SystemDisposition == "Answered Machine" || a
                    .SystemDisposition == "Answered Machine Abandoned" || a
                    .SystemDisposition == "Answered Machine Agentconnect" || a
                    .SystemDisposition == "Answered Notsure" || a
                    .SystemDisposition == "Answered Notsure Abandoned" || a
                    .SystemDisposition == "Answered Notsure Agentconnect")
                    )
                    .GroupBy(d => new
                    {
                        adjYear = d.CallStartDate.Date.Year,
                        adjMonth = d.CallStartDate.Date.Month,
                        ajdDay = d.CallStartDate.Date.Day,
                    }
                    ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
                    .ToDictionary(k => k.date, i => i.count);

                // Get All Connected Considered for Abandoned Rate
                var callsConsideredForAbandonedFromDataset = datasetCalls
                    .Where(a => a
                    .CallStartDate >= start && a
                    .CallStartDate <= end && (a
                    .SystemDisposition == "Answered Human Abandoned" || a
                    .SystemDisposition == "Answered Human Agentconnect" || a
                    .SystemDisposition == "Answered Machine" || a
                    .SystemDisposition == "Answered Machine Abandoned" || a
                    .SystemDisposition == "Answered Machine Agentconnect" || a
                    .SystemDisposition == "Answered Notsure" || a
                    .SystemDisposition == "Answered Notsure Abandoned" || a
                    .SystemDisposition == "Answered Notsure Agentconnect")
                    )
                    .GroupBy(d => new
                    {
                        adjYear = d.CallStartDate.Date.Year,
                        adjMonth = d.CallStartDate.Date.Month,
                        ajdDay = d.CallStartDate.Date.Day,
                    }
                    ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
                    .ToDictionary(k => k.date, i => i.count);


                // Get All Connected Calls From Dataset
                var callsHumanConnectedFromDataset = datasetCalls
                    .Where(a => a
                    .CallStartDate >= start && a
                    .CallStartDate <= end && (a
                    .SystemDisposition == "Answered Human Agentconnect" || a
                    .SystemDisposition == "Answered Machine Agentconnect" || a
                    .SystemDisposition == "Answered Notsure Agentconnect")
                    )
                    .GroupBy(d => new
                    {
                        adjYear = d.CallStartDate.Date.Year,
                        adjMonth = d.CallStartDate.Date.Month,
                        ajdDay = d.CallStartDate.Date.Day,
                    }
                    ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
                    .ToDictionary(k => k.date, i => i.count);

                // Get All Connected Abandoned Calls From Dataset
                var callsTotalAbandonedFromDataset = datasetCalls
                    .Where(a => a
                    .CallStartDate >= start && a
                    .CallStartDate <= end && (a
                    .SystemDisposition == "Answered Human Abandoned" || a
                    .SystemDisposition == "Answered Machine Abandoned" || a
                    .SystemDisposition == "Answered Notsure Abandoned")
                    )
                    .GroupBy(d => new
                    {
                        adjYear = d.CallStartDate.Date.Year,
                        adjMonth = d.CallStartDate.Date.Month,
                        ajdDay = d.CallStartDate.Date.Day,
                    }
                    ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
                    .ToDictionary(k => k.date, i => i.count);

                // Get All HUMAN Connected Calls From Dataset
                var callsHumanAbandonedFromDataset = datasetCalls
                    .Where(a => a
                    .CallStartDate >= start && a
                    .CallStartDate <= end && (a
                    .SystemDisposition == "Answered Human Abandoned" || a
                    .SystemDisposition == "Answered Notsure Abandoned")
                    )
                    .GroupBy(d => new
                    {
                        adjYear = d.CallStartDate.Date.Year,
                        adjMonth = d.CallStartDate.Date.Month,
                        ajdDay = d.CallStartDate.Date.Day,
                    }
                    ).Select(g => new { date = $"{g.Key.adjYear}/{g.Key.adjMonth}/{g.Key.ajdDay}", count = g.Count() })
                    .ToDictionary(k => k.date, i => i.count);

                //Used in Charts

                // Normalizaed Dates for Human Connected 
                var callsConnectedFromDatasetNormalized = 
                    CompareDictionaries.CompareDictionaryReturnSecondOne(callsByDateFromDataset, callsConnectedFromDataset);
                
                var callsHumanConnectedFromDatasetNormalized =
                    CompareDictionaries.CompareDictionaryReturnSecondOne(callsByDateFromDataset, callsHumanConnectedFromDataset);

                // Total Talked Time
                var totalTalkedTimeFromDataset = datasetCalls
                    .Where(a => a
                    .CallStartDate >= start && a
                    .CallStartDate <= end && a
                    .SystemDisposition == "Answered Human Agentconnect" || a
                    .SystemDisposition == "Answered Machine Agentconnect" || a
                    .SystemDisposition == "Answered Notsure Agentconnect").ToList();

                //System disposition
                var callsSystemDispositionFromDataset = datasetCalls
                    .GroupBy(d => new
                    {
                        systemDispo = d.SystemDisposition.ToLower(),
                    }
                    )
                    .Select(g => new { systemDisposition = $"{g.Key.systemDispo}", count = g.Count() })
                    .OrderByDescending(o => o.count)
                    .ToDictionary(k => k.systemDisposition, i => i.count);

                //Call disposition
                var callsDispositionFromDataset = datasetCalls
                    .Where(c => c.CallDisposition != null && c.CallDisposition != String.Empty)
                    .GroupBy(d => new
                    {
                        callDispo = d.CallDisposition.ToLower(),
                    }
                    )
                    .Select(g => new { callDisposition = $"{g.Key.callDispo}", count = g.Count() })
                    .OrderByDescending(o => o.count)
                    .ToDictionary(k => k.callDisposition, i => i.count);

                // Get Campaigns
                SelectList campaignsList = new SelectList(_context
                    .Campaigns
                    .Where(c => c
                    .TenantId == 1 && c
                    .Name != "").ToList().Distinct(), "campaignId", "campaignName");
                ViewBag.Campaigns = campaignsList;


                var connectionRate = MathOperations.DivisionReturnPercentage(callsConnectedFromDatasetNormalized.Values.Sum(), callsByDateFromDataset.Values.Sum());
                var connectionAgentRate = MathOperations.DivisionReturnPercentage(callsHumanConnectedFromDatasetNormalized.Values.Sum(), callsByDateFromDataset.Values.Sum());
                var convertionRate = MathOperations.DivisionReturnPercentage(sumLeads, callsHumanConnectedFromDatasetNormalized.Values.Sum());
                var dropRate = MathOperations.DivisionReturnPercentage(callsTotalAbandonedFromDataset.Values.Sum(), callsConsideredForAbandonedFromDataset.Values.Sum());
                var leadsCount = totalLeads; 
                var totalTalkedTime = Math.Round((decimal)totalTalkedTimeFromDataset.Sum(t => t.CallDuration) / 60) / 60;
                var averageTalkedTime = Math.Round((double)(totalTalkedTimeFromDataset.Average(t => t.CallDuration))) / 60;
                var agentDropRate = MathOperations.DivisionReturnPercentage(callsHumanAbandonedFromDataset.Values.Sum(), callsConsideredForAbandonedFromDataset.Values.Sum());
                var callToGetLead = totalLeads.Values.Sum() > 0 ? callsConnectedFromDatasetNormalized.Values.Sum() / totalLeads.Values.Sum() : 0;
                var callsSystemDispositions = callsSystemDispositionFromDataset;
                var callsDisposition = callsDispositionFromDataset;

                var endTime = DateTime.Now;
                var resultTime = endTime - startTime;
                var tupleList = new List<dynamic>();

                tupleList.Add(new Tuple<string, dynamic>("callsByDateFromDataset", callsByDateFromDataset));
                tupleList.Add(new Tuple<string, dynamic>("callsConnected", callsConnectedFromDatasetNormalized));
                tupleList.Add(new Tuple<string, dynamic>("callsHumanConnected", callsHumanConnectedFromDatasetNormalized));
                tupleList.Add(new Tuple<string, dynamic>("connectionRate", connectionRate));
                tupleList.Add(new Tuple<string, dynamic>("connectionAgentRate", connectionAgentRate));
                tupleList.Add(new Tuple<string, dynamic>("convertionRate", convertionRate));
                tupleList.Add(new Tuple<string, dynamic>("dropRate", dropRate));
                tupleList.Add(new Tuple<string, dynamic>("leadsCount", leadsCount));
                tupleList.Add(new Tuple<string, dynamic>("totalTalkedTime", totalTalkedTime));
                tupleList.Add(new Tuple<string, dynamic>("averageTalkedTime", averageTalkedTime));
                tupleList.Add(new Tuple<string, dynamic>("agentDropRate", agentDropRate));
                tupleList.Add(new Tuple<string, dynamic>("callToGetLead", callToGetLead));
                tupleList.Add(new Tuple<string, dynamic>("callsSystemDispositions", callsSystemDispositions));
                tupleList.Add(new Tuple<string, dynamic>("callsDisposition", callsDisposition));

                return Json(tupleList);

            }
            catch (Exception ex)
            {

                return Json(ex.Message);
            }


        }

        // GET: ProviderHistoryCalls
        public async Task<IActionResult> Index_old()
        {
            var calls = _context.ProviderHistoryCalls
                .Include(p => p.Provider)
                .Take(1000000)
                .Where(p => p.PropertyId == 5655);
            return View(await calls.ToListAsync());
        }

        // GET: ProviderHistoryCalls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerHistoryCall = await _context.ProviderHistoryCalls
                .Include(p => p.Provider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerHistoryCall == null)
            {
                return NotFound();
            }

            return View(providerHistoryCall);
        }

        // GET: ProviderHistoryCalls/Create
        public IActionResult Create()
        {
            ViewData["ProviderId"] = new SelectList(_context.ThirdPartProviders, "Id", "ProviderName");
            return View();
        }

        // POST: ProviderHistoryCalls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenantId,PropertyId,ProviderId,CampaignId,CampaignName,OutboundPhoneId,DestinationPhone,CallId,CallStartDate,CallDuration,CallDisposition,SystemDisposition,CallRecordPath,AgentName,DirectionType,ContactDisposition")] ProviderHistoryCall providerHistoryCall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(providerHistoryCall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProviderId"] = new SelectList(_context.ThirdPartProviders, "Id", "ProviderName", providerHistoryCall.ProviderId);
            return View(providerHistoryCall);
        }

        // GET: ProviderHistoryCalls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerHistoryCall = await _context.ProviderHistoryCalls.FindAsync(id);
            if (providerHistoryCall == null)
            {
                return NotFound();
            }
            ViewData["ProviderId"] = new SelectList(_context.ThirdPartProviders, "Id", "ProviderName", providerHistoryCall.ProviderId);
            return View(providerHistoryCall);
        }

        // POST: ProviderHistoryCalls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenantId,PropertyId,ProviderId,CampaignId,CampaignName,OutboundPhoneId,DestinationPhone,CallId,CallStartDate,CallDuration,CallDisposition,SystemDisposition,CallRecordPath,AgentName,DirectionType,ContactDisposition")] ProviderHistoryCall providerHistoryCall)
        {
            if (id != providerHistoryCall.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(providerHistoryCall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderHistoryCallExists(providerHistoryCall.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProviderId"] = new SelectList(_context.ThirdPartProviders, "Id", "ProviderName", providerHistoryCall.ProviderId);
            return View(providerHistoryCall);
        }

        // GET: ProviderHistoryCalls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var providerHistoryCall = await _context.ProviderHistoryCalls
                .Include(p => p.Provider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (providerHistoryCall == null)
            {
                return NotFound();
            }

            return View(providerHistoryCall);
        }

        // POST: ProviderHistoryCalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var providerHistoryCall = await _context.ProviderHistoryCalls.FindAsync(id);
            _context.ProviderHistoryCalls.Remove(providerHistoryCall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProviderHistoryCallExists(int id)
        {
            return _context.ProviderHistoryCalls.Any(e => e.Id == id);
        }
    }
}
