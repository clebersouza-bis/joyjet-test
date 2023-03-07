using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bridge.ERP.Models;
using PodioAPI;
using System.Net;
using System.Text;
using System.IO;

namespace Bridge.ERP.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly bidbdesenvContext _context;
        //private IEnumerable<Properties> _prop;
        public Podio PodioClient { get; set; } 

        public PropertiesController(bidbdesenvContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> PostPodioForm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = await _context.Properties.FindAsync(id);
            properties.Phone = await _context.Phones.Where(p => p.PropertyId == id).ToListAsync();
         

            if (properties == null)
            {
                return NotFound();
            }
            return View(properties);
        }
        public async Task<string> PostToPodio(Properties properties)
        {
               var result = "AINDA NÂO IMPLEMENTADO";
               return result;

        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "Teste post seacr " + searchString;
        }

        // GET: Properties
        public async Task<IActionResult> Index(string searchString, string searchType)
        {
            var properties = await _context.Properties.Take(100).ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                if (searchType =="address")
                {
                    properties = await _context.Properties
                        .Where(p => p.PropertyAddress.Contains(searchString)).ToListAsync();
                }
                else if (searchType == "firstName")
                {
                    properties = await _context.Properties
                         .Where(p => p.FirstName.Contains(searchString)).ToListAsync();
                }
                else if (searchType == "lastName")
                {
                    properties = await _context.Properties
                         .Where(p => p.LastName.Contains(searchString)).ToListAsync();
                }
                else if (searchType == "phone")
                {
                    var phone = await _context.Phones
                        .Include(p => p.Property)
                        .Where(c => c.Phone.Contains(searchString)).ToListAsync();
                    
                    var _prop = new List<Properties>();
                    
                    foreach (var item in phone)
                    {

                        _prop.Add(item.Property);

                        //p = new Properties()
                        //{
                        //    Id = item.Property.Id,
                        //    PropertyAddress = item.Property.PropertyAddress,
                        //    PropertyCity = item.Property.PropertyCity,
                        //    PropertyState = item.Property.PropertyState,
                        //    PropertyZip = item.Property.PropertyZip,
                        //    FirstName = item.Property.FirstName,
                        //    LastName = item.Property.LastName
                        //};                        
                    }
                    return View(_prop);
                    
                }
            }

            return View(properties);
        }


        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = await _context.Properties
                .FirstOrDefaultAsync(m => m.Id == id);

            var Pproperties = await _context.Phones
                .Where(p => p.PropertyId == id).ToListAsync();

            if (properties == null)
            {
                return NotFound();
            }

            return View(properties);
        }

        // GET: Properties/DetailsPhones/5
        public async Task<IActionResult> DetailsPhone(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = await _context.Properties
                .FirstOrDefaultAsync(m => m.Id == id);

            var Pproperties = await _context.Phones
                .Where(p => p.PropertyId == id && p.ContactType == "S").ToListAsync();

            if (properties == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsPhone", properties);
        }
        // GET: Properties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenantId,PropertyAddress,PropertyCity,PropertyState,PropertyZip,FirstName,LastName,ListCount,MailerCount,Email,Email2,OptOut,PropertyCounty,MailingAddress,MailingCity,MailingState,MailingZip,MailingCounty,IsVacant,IsMailingVacant,ApnNumber,PropertyTypeDetail,OwnerOccupied,BedroomCount,BathroomCount,TotalBuildingAreaSquareFeet,LotSizeSquareFeet,YearBuilt,TotalAssessedValue,ZoningCode,LastStaleDate,LastSalePrice,TotalOpenLienBalance,EquityCurrentEstimatedBalance,EstimatedValue,LtvCurrentEstimatedCombined,MlsStatus,Owner2FirstName,Owner2LastName,PropertyType,PrimaryListSource,PrimaryListType,CriticalStatus,HotLead,MatchCrm")] Properties properties)
        {
            if (ModelState.IsValid)
            {
                _context.Add(properties);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(properties);
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = await _context.Properties.FindAsync(id);
            if (properties == null)
            {
                return NotFound();
            }
            return View(properties);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenantId,PropertyAddress,PropertyCity,PropertyState,PropertyZip,FirstName,LastName,ListCount,MailerCount,Email,Email2,OptOut,PropertyCounty,MailingAddress,MailingCity,MailingState,MailingZip,MailingCounty,IsVacant,IsMailingVacant,ApnNumber,PropertyTypeDetail,OwnerOccupied,BedroomCount,BathroomCount,TotalBuildingAreaSquareFeet,LotSizeSquareFeet,YearBuilt,TotalAssessedValue,ZoningCode,LastStaleDate,LastSalePrice,TotalOpenLienBalance,EquityCurrentEstimatedBalance,EstimatedValue,LtvCurrentEstimatedCombined,MlsStatus,Owner2FirstName,Owner2LastName,PropertyType,PrimaryListSource,PrimaryListType,CriticalStatus,HotLead,MatchCrm")] Properties properties)
        {
            if (id != properties.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(properties);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertiesExists(properties.Id))
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
            return View(properties);
        }

        // GET: Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = await _context.Properties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (properties == null)
            {
                return NotFound();
            }

            return View(properties);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var properties = await _context.Properties.FindAsync(id);
            _context.Properties.Remove(properties);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertiesExists(int id)
        {
            return _context.Properties.Any(e => e.Id == id);
        }
    }
}
