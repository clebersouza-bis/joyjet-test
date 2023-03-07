using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bridge.ERP;
using Microsoft.AspNetCore.Authorization;
using Bridge.ERP.Models;

namespace Bridge.ERP.Controllers
{
    [Authorize]
    public class ListsController : Controller
    {
        private readonly bidbdesenvContext _context;

        public ListsController(bidbdesenvContext context)
        {
            _context = context;
        }

        // GET: Lists
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lists.ToListAsync());
        }

        // GET: Lists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lists = await _context.Lists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lists == null)
            {
                return NotFound();
            }

            return View(lists);
        }

        // GET: Lists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenantId,ListName,ListType,IsDelete,IsActive,ListDescription")] Lists lists)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lists);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lists);
        }

        // GET: Lists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lists = await _context.Lists.FindAsync(id);
            if (lists == null)
            {
                return NotFound();
            }
            return View(lists);
        }

        // POST: Lists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenantId,ListName,ListType,IsDelete,IsActive,ListDescription")] Lists lists)
        {
            if (id != lists.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lists);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListsExists(lists.Id))
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
            return View(lists);
        }

        // GET: Lists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lists = await _context.Lists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lists == null)
            {
                return NotFound();
            }

            return View(lists);
        }

        // POST: Lists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lists = await _context.Lists.FindAsync(id);
            _context.Lists.Remove(lists);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListsExists(int id)
        {
            return _context.Lists.Any(e => e.Id == id);
        }
    }
}
