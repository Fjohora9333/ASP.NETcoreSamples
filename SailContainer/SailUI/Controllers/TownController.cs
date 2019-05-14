using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SailUI.Models;

namespace SailUI.Controllers
{
    public class TownController : Controller
    {
        private readonly SailContext _context;

        public TownController(SailContext context)
        {
            _context = context;
        }

        // GET: Town
        public async Task<IActionResult> Index()
        {
            return View(await _context.Town.ToListAsync());
        }

        // GET: Town/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Town
                .FirstOrDefaultAsync(m => m.TownName == id);
            if (town == null)
            {
                return NotFound();
            }

            return View(town);
        }

        // GET: Town/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Town/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TownName,ProvinceCode")] Town town)
        {
            if (ModelState.IsValid)
            {
                _context.Add(town);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(town);
        }

        // GET: Town/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Town.FindAsync(id);
            if (town == null)
            {
                return NotFound();
            }
            return View(town);
        }

        // POST: Town/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TownName,ProvinceCode")] Town town)
        {
            if (id != town.TownName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(town);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TownExists(town.TownName))
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
            return View(town);
        }

        // GET: Town/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Town
                .FirstOrDefaultAsync(m => m.TownName == id);
            if (town == null)
            {
                return NotFound();
            }

            return View(town);
        }

        // POST: Town/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var town = await _context.Town.FindAsync(id);
            _context.Town.Remove(town);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TownExists(string id)
        {
            return _context.Town.Any(e => e.TownName == id);
        }
    }
}
