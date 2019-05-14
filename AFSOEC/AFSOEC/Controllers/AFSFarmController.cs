using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AFSOEC.Models;

/// <summary>
/// /////Fatima Assignment 4 2019
/// </summary>
namespace AFSOEC.Controllers
{
    public class AFSFarmController : Controller
    {
        private readonly OECContext _context;

        public AFSFarmController(OECContext context)
        {
            _context = context;
        }

        // GET: AFSFarm
        public async Task<IActionResult> Index()
        {
            var oECContext = _context.Farm
                            .Include(f => f.ProvinceCodeNavigation)
                            .OrderBy(f=> f.Name)
                            .ThenBy(f=>f.ProvinceCodeNavigation.Name);
            return View(await oECContext.ToListAsync());
        }

        // GET: AFSFarm/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farm = await _context.Farm
                .Include(f => f.ProvinceCodeNavigation)
                .FirstOrDefaultAsync(m => m.FarmId == id);
            if (farm == null)
            {
                return NotFound();
            }

            return View(farm);
        }

        // GET: AFSFarm/Create
        public IActionResult Create()
        {
            ViewData["ProvinceCode"] = new SelectList(_context.Province, "ProvinceCode", "ProvinceCode");
            return View();
        }

        // POST: AFSFarm/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FarmId,Name,Address,Town,County,ProvinceCode,PostalCode,HomePhone,CellPhone,Email,Directions,DateJoined,LastContactDate")] Farm farm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(farm);
                    TempData["Message"] = "New farm is created successfully";
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", $"error editing existing farm:{ex.GetBaseException().Message} ");
            }
            //ViewData["ProvinceCode"] = new SelectList(_context.Province, "ProvinceCode", "ProvinceCode", farm.ProvinceCode);
            return View(farm);
        }

        // GET: AFSFarm/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
                
            }

            var farm = await _context.Farm.FindAsync(id);
            if (farm == null)
            {
                return NotFound();
            }
            ViewData["ProvinceName"] = new SelectList(_context.Province.OrderBy(p=>p.Name), "ProvinceCode", "Name", farm.ProvinceCode);
            return View(farm);
        }

        // POST: AFSFarm/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FarmId,Name,Address,Town,County,ProvinceCode,PostalCode,HomePhone,CellPhone,Email,Directions,DateJoined,LastContactDate")] Farm farm)
        {
            if (id != farm.FarmId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    TempData["Message"] = "Farm is successfully edited !";
                    _context.Update(farm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    if (!FarmExists(farm.FarmId))
                    {
                        return NotFound();
                    }
                    else
                    {

                        ModelState.AddModelError("", $"error editing existing farm:{ex.GetBaseException().Message} ");
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProvinceCode"] = new SelectList(_context.Province.OrderBy(p=>p.Name), "ProvinceCode", "Name", farm.ProvinceCode);
            return View(farm);
        }

        // GET: AFSFarm/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farm = await _context.Farm
                .Include(f => f.ProvinceCodeNavigation)
                .FirstOrDefaultAsync(m => m.FarmId == id);
            if (farm == null)
            {
                return NotFound();
            }

            return View(farm);
        }

        // POST: AFSFarm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var farm = await _context.Farm.FindAsync(id);
                _context.Farm.Remove(farm);
                TempData["message"] = "Firm deleted successfully.";
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["message"] = "Error deleting firm :" + ex.GetBaseException().Message;

            }
            return RedirectToAction(nameof(Delete));

        }

        private bool FarmExists(int id)
        {
            return _context.Farm.Any(e => e.FarmId == id);
        }
    }
}
