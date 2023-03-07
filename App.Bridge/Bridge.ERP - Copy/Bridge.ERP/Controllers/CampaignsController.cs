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

namespace Bridge.ERP.Controllers
{
    public class CampaignsController : Controller
    {
        private readonly bidbdesenvContext _context;

        public CampaignsController(bidbdesenvContext context)
        {
            _context = context;
        }

        // GET: Campaigns
        public async Task<IActionResult> Index()
        {
            return View(await _context.Campaigns.ToListAsync());
        }

        // GET: Campaigns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaigns = await _context.Campaigns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campaigns == null)
            {
                return NotFound();
            }

            return View(campaigns);
        }

        // GET: Campaigns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Campaigns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenantId,Name,Description,MarketType,Pipeline,Status")] Campaign campaigns)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campaigns);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campaigns);
        }

        // GET: Campaigns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaigns = await _context.Campaigns.FindAsync(id);
            if (campaigns == null)
            {
                return NotFound();
            }
            return View(campaigns);
        }

        // POST: Campaigns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenantId,Name,Description,MarketType,Pipeline,Status")] Campaign campaigns)
        {
            if (id != campaigns.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campaigns);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampaignsExists(campaigns.Id))
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
            return View(campaigns);
        }

        // GET: Campaigns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaigns = await _context.Campaigns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campaigns == null)
            {
                return NotFound();
            }

            return View(campaigns);
        }

        // POST: Campaigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campaigns = await _context.Campaigns.FindAsync(id);
            _context.Campaigns.Remove(campaigns);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampaignsExists(int id)
        {
            return _context.Campaigns.Any(e => e.Id == id);
        }
    }
}
