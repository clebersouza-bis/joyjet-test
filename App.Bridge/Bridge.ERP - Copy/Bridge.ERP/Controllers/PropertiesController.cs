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
using Bridge.ERP.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Bridge.ERP.Data.Dto;
using CsvHelper;
using System.Globalization;

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

            var properties = await _context.Properties
                .Include(p => p)
                .FirstOrDefaultAsync(d => d.Id == id);

            //properties.Phones = await _context.Phones.Where(p => p.PropertyId == id).ToListAsync();
         

            if (properties == null)
            {
                return NotFound();
            }
            return View(properties);
        }
        public async Task<string> PostToPodio(Property property)
        {
               var result = "AINDA NÂO IMPLEMENTADO";
               return result;

        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "Teste post search " + searchString;
        }
        // GET: Properties
        public async Task<IActionResult> Index(string searchString, string searchType)
        {
                var properties = await _context.Properties.Take(25).ToListAsync();

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
                        .Where(c => c.PhoneNumber.Contains(searchString)).ToListAsync();
                    
                    var _prop = new List<Property>();
                    
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

        public async Task<IActionResult> Index2(string searchString, string searchType)
        {
            var properties = await _context.Properties.Take(100).ToListAsync();
            return View(properties);
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
                .Include(p => p.Phones)
                .FirstOrDefaultAsync(m => m.Id == id);

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
        public async Task<IActionResult> Create([Bind("Id,TenantId,PropertyAddress,PropertyCity,PropertyState,PropertyZip,FirstName,LastName,ListCount,MailerCount,Email,Email2,OptOut,PropertyCounty,MailingAddress,MailingCity,MailingState,MailingZip,MailingCounty,IsVacant,IsMailingVacant,ApnNumber,PropertyTypeDetail,OwnerOccupied,BedroomCount,BathroomCount,TotalBuildingAreaSquareFeet,LotSizeSquareFeet,YearBuilt,TotalAssessedValue,ZoningCode,LastStaleDate,LastSalePrice,TotalOpenLienBalance,EquityCurrentEstimatedBalance,EstimatedValue,LtvCurrentEstimatedCombined,MlsStatus,Owner2FirstName,Owner2LastName,PropertyType,PrimaryListSource,PrimaryListType,CriticalStatus,HotLead,MatchCrm")] Property property)
        {
            if (ModelState.IsValid)
            {
                _context.Add(property);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(property);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenantId,PropertyAddress,PropertyCity,PropertyState,PropertyZip,FirstName,LastName,ListCount,MailerCount,Email,Email2,OptOut,PropertyCounty,MailingAddress,MailingCity,MailingState,MailingZip,MailingCounty,IsVacant,IsMailingVacant,ApnNumber,PropertyTypeDetail,OwnerOccupied,BedroomCount,BathroomCount,TotalBuildingAreaSquareFeet,LotSizeSquareFeet,YearBuilt,TotalAssessedValue,ZoningCode,LastStaleDate,LastSalePrice,TotalOpenLienBalance,EquityCurrentEstimatedBalance,EstimatedValue,LtvCurrentEstimatedCombined,MlsStatus,Owner2FirstName,Owner2LastName,PropertyType,PrimaryListSource,PrimaryListType,CriticalStatus,HotLead,MatchCrm")] Property property)
        {
            if (id != property.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertiesExists(property.Id))
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
            return View(property);
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

        public async Task<IActionResult> UploadCsv(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            #region Upload CSV File
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            #endregion

            var properties = this.GetPropertiesList(fileName);
            return View(properties);
        }

        private List<PropertyDto> GetPropertiesList(string fileName)
        {
            List<PropertyDto> properties = new List<PropertyDto>(); 

            // Read a CSV
            var path =  fileName;
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var property = csv.GetRecord<PropertyDto>();
                    property.TenantId = 2;
                    properties.Add(property);
                }                                
            }
            //Create a CSV
            path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\filesTo"}";
            using (var write = new StreamWriter(path))
            using (var csv = new CsvWriter(write, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(properties);
            }
            return properties;  

        }
    }
}
