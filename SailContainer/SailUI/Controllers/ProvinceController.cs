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
    public class ProvinceController : Controller
    {
        private readonly SailContext _context;

        public ProvinceController(SailContext context)
        {
            _context = context;
        }

        // GET: Province
        public async Task<IActionResult> Index()
        {
            
            var sailContext = _context.Province.Include(p => p.CountryCodeNavigation);
            return View(await sailContext.ToListAsync());
        }

        // GET: Province/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var province = await _context.Province
                .Include(p => p.CountryCodeNavigation)
                .FirstOrDefaultAsync(m => m.ProvinceCode == id);
            if (province == null)
            {
                return NotFound();
            }

            return View(province);
        }

        // GET: Province/Create
        public IActionResult Create()
        {
            ViewData["CountryCode"] = new SelectList(_context.Country, "CountryCode", "CountryCode");
            return View();
        }

        // POST: Province/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProvinceCode,Name,CountryCode,TaxCode,TaxRate,Capital,IncludesFerderalTax")] Province province)
        {
            try
            {
                await TryUpdateModelAsync(province);
                if (ModelState.IsValid)
                {
                    _context.Add(province);
                    await _context.SaveChangesAsync();
                    TempData["message"] = "New province created successfully..";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch(Exception ex)
            {
                TempData["message"] = "Error creating new province: " + ex.GetBaseException().Message;
            }
            
            ViewData["CountryCode"] = new SelectList(_context.Country, "CountryCode", "CountryCode", province.CountryCode);
            return View(province);
        }

        // GET: Province/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var province = await _context.Province.FindAsync(id);
            if (province == null)
            {
                return NotFound();
            }
            ViewData["CountryCode"] = new SelectList(_context.Country, "CountryCode", "CountryCode", province.CountryCode);
            return View(province);
        }

        // POST: Province/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProvinceCode,Name,CountryCode,TaxCode,TaxRate,Capital,IncludesFerderalTax")] Province province)
        {
            if (id != province.ProvinceCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Province thisProvince = province;

                    thisProvince.ProvinceCode = province.ProvinceCode;
                    thisProvince.Name = province.Name;

                    _context.Update(thisProvince);
                    TempData["message"] = "Province edited successfully..";
                    await _context.SaveChangesAsync();

                    
                }
                catch (Exception ex)
                {
                    if (!ProvinceExists(province.ProvinceCode))
                    {
                        return NotFound();
                    }
                    else
                    {
                        TempData["message"] = "Error editing province: " + ex.GetBaseException().Message;

                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryCode"] = new SelectList(_context.Country, "CountryCode", "CountryCode", province.CountryCode);
            return View(province);
        }

        // GET: Province/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var province = await _context.Province
                .Include(p => p.CountryCodeNavigation)
                .FirstOrDefaultAsync(m => m.ProvinceCode == id);
            if (province == null)
            {
                return NotFound();
            }

            return View(province);
        }

        // POST: Province/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            try
            {
                var province = await _context.Province.FindAsync(id);
                _context.Province.Remove(province);
                await _context.SaveChangesAsync();
                TempData["message"] = "Province delete successfull.. ";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["message"] = "Error Deleting province: " + ex.GetBaseException().Message;

            }
            return RedirectToAction(nameof(Delete));

        }

        private bool ProvinceExists(string id)
        {
            return _context.Province.Any(e => e.ProvinceCode == id);
        }
    }
}
