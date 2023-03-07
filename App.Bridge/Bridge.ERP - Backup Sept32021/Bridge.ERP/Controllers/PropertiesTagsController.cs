using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bridge.ERP;
using Bridge.ERP.Models;

namespace Bridge.ERP.Controllers
{
    public class PropertiesTagsController : Controller
    {
        private readonly bidbdesenvContext _context;

        public PropertiesTagsController(bidbdesenvContext context)
        {
            _context = context;
        }

        // GET: PropertiesTags
        public async Task<IActionResult> Index()
        {
            var bidbdesenvContext = _context.PropertiesTags.Include(p => p.Property).Include(p => p.Tag);
            return View(await bidbdesenvContext.ToListAsync());
        }

        // GET: PropertiesTags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertiesTags = await _context.PropertiesTags
                .Include(p => p.Property)
                .Include(p => p.Tag)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propertiesTags == null)
            {
                return NotFound();
            }

            return View(propertiesTags);
        }

        // GET: PropertiesTags/Create
        public IActionResult Create()
        {
            ViewData["PropertyId"] = new SelectList(_context.Properties, "Id", "PropertyAddress");
            ViewData["TagId"] = new SelectList(_context.Tags, "Id", "TagName");
            return View();
        }

        // POST: PropertiesTags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenantId,TagId,PropertyId,IsDelete,IsActive")] PropertiesTag propertieTags)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propertieTags);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PropertyId"] = new SelectList(_context.Properties, "Id", "PropertyAddress", propertieTags.PropertyId);
            ViewData["TagId"] = new SelectList(_context.Tags, "Id", "TagName", propertieTags.TagId);
            return View(propertieTags);
        }

        // GET: PropertiesTags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertiesTags = await _context.PropertiesTags.FindAsync(id);
            if (propertiesTags == null)
            {
                return NotFound();
            }
            ViewData["PropertyId"] = new SelectList(_context.Properties, "Id", "PropertyAddress", propertiesTags.PropertyId);
            ViewData["TagId"] = new SelectList(_context.Tags, "Id", "TagName", propertiesTags.TagId);
            return View(propertiesTags);
        }

        // POST: PropertiesTags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenantId,TagId,PropertyId,IsDelete,IsActive")] PropertiesTag propertiesTag)
        {
            if (id != propertiesTag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propertiesTag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertiesTagsExists(propertiesTag.Id))
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
            ViewData["PropertyId"] = new SelectList(_context.Properties, "Id", "PropertyAddress", propertiesTag.PropertyId);
            ViewData["TagId"] = new SelectList(_context.Tags, "Id", "TagName", propertiesTag.TagId);
            return View(propertiesTag);
        }

        // GET: PropertiesTags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertiesTags = await _context.PropertiesTags
                .Include(p => p.Property)
                .Include(p => p.Tag)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propertiesTags == null)
            {
                return NotFound();
            }

            return View(propertiesTags);
        }

        // POST: PropertiesTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propertiesTags = await _context.PropertiesTags.FindAsync(id);
            _context.PropertiesTags.Remove(propertiesTags);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertiesTagsExists(int id)
        {
            return _context.PropertiesTags.Any(e => e.Id == id);
        }
    }
}
