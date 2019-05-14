using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AFSOEC.Models;
using Microsoft.AspNetCore.Http;

namespace AFSOEC.Controllers
{
    public class AFSTreatmentFertilizerController : Controller
    {
        private readonly OECContext _context;

        public AFSTreatmentFertilizerController(OECContext context)
        {
            _context = context;
        }

        // GET: AFSTreatmentFertilizer
        public async Task<IActionResult> Index(int treatmentId)
        {
            int currentTreatmentId = treatmentId;
            if (currentTreatmentId==0)
            {
                currentTreatmentId =(int) HttpContext.Session.GetInt32("currentTreatmentId");
            }
            else if(treatmentId==0 && currentTreatmentId==0)
            {
                TempData["Message"] = "Please select a treatment";
                return RedirectToAction("Index", "Treatment");
            }
            HttpContext.Session.SetInt32(nameof(currentTreatmentId), currentTreatmentId);

            var oECContext = _context.TreatmentFertilizer
                .Include(t => t.FertilizerNameNavigation)
                .Include(t => t.Treatment)
                .Where(t=>t.TreatmentId== currentTreatmentId)
                .OrderBy(t=>t.FertilizerName);
            return View(await oECContext.ToListAsync());
        }

        // GET: AFSTreatmentFertilizer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treatmentFertilizer = await _context.TreatmentFertilizer
                .Include(t => t.FertilizerNameNavigation)
                .Include(t => t.Treatment)
                .FirstOrDefaultAsync(m => m.TreatmentFertilizerId == id);
            if (treatmentFertilizer == null)
            {
                return NotFound();
            }

            return View(treatmentFertilizer);
        }

        // GET: AFSTreatmentFertilizer/Create
        public IActionResult Create()
        {
            
            ViewData["FertilizerName"] = new SelectList(_context.Fertilizer.OrderBy(f=>f.FertilizerName), "FertilizerName", "FertilizerName");
            ViewData["TreatmentId"] = new SelectList(_context.Treatment, "TreatmentId", "TreatmentId");
            return View();
        }
       public IActionResult GetRateMetric(string FertilizerName)
        {
            var liquid = _context.Fertilizer
                        .Where(f => f.FertilizerName == FertilizerName)
                        .Select(f => f.Liquid)
                        .FirstOrDefault();
            if (liquid)
            {
                ViewBag.RateMetric = "GAL";
            }
            else
            {
                ViewBag.RateMetric = "LB";
            }
            return Content(ViewBag.RateMetric);

        }

        // POST: AFSTreatmentFertilizer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TreatmentFertilizerId,TreatmentId,FertilizerName,RatePerAcre,RateMetric")] TreatmentFertilizer treatmentFertilizer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(treatmentFertilizer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FertilizerName"] = new SelectList(_context.Fertilizer, "FertilizerName", "FertilizerName", treatmentFertilizer.FertilizerName);
            ViewData["TreatmentId"] = new SelectList(_context.Treatment, "TreatmentId", "TreatmentId", treatmentFertilizer.TreatmentId);
            return View(treatmentFertilizer);
        }

        // GET: AFSTreatmentFertilizer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treatmentFertilizer = await _context.TreatmentFertilizer.FindAsync(id);
            if (treatmentFertilizer == null)
            {
                return NotFound();
            }
            ViewData["FertilizerName"] = new SelectList(_context.Fertilizer.OrderBy(f => f.FertilizerName), "FertilizerName", "FertilizerName", treatmentFertilizer.FertilizerName);
            ViewData["TreatmentId"] = new SelectList(_context.Treatment, "TreatmentId", "TreatmentId", treatmentFertilizer.TreatmentId);
            return View(treatmentFertilizer);
        }

        // POST: AFSTreatmentFertilizer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TreatmentFertilizerId,TreatmentId,FertilizerName,RatePerAcre,RateMetric")] TreatmentFertilizer treatmentFertilizer)
        {
            if (id != treatmentFertilizer.TreatmentFertilizerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(treatmentFertilizer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TreatmentFertilizerExists(treatmentFertilizer.TreatmentFertilizerId))
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
            //var rateMetric = _context.Fertilizer.Where(f => f.Liquid == true);
            //if (rateMetric==true)
            //{

            //}
            ViewData["FertilizerName"] = new SelectList(_context.Fertilizer, "FertilizerName", "FertilizerName", treatmentFertilizer.FertilizerName);
            ViewData["TreatmentId"] = new SelectList(_context.Treatment, "TreatmentId", "TreatmentId", treatmentFertilizer.TreatmentId);
            return View(treatmentFertilizer);
        }

        // GET: AFSTreatmentFertilizer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treatmentFertilizer = await _context.TreatmentFertilizer
                .Include(t => t.FertilizerNameNavigation)
                .Include(t => t.Treatment)
                .FirstOrDefaultAsync(m => m.TreatmentFertilizerId == id);
            if (treatmentFertilizer == null)
            {
                return NotFound();
            }

            return View(treatmentFertilizer);
        }

        // POST: AFSTreatmentFertilizer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var treatmentFertilizer = await _context.TreatmentFertilizer.FindAsync(id);
            _context.TreatmentFertilizer.Remove(treatmentFertilizer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TreatmentFertilizerExists(int id)
        {
            return _context.TreatmentFertilizer.Any(e => e.TreatmentFertilizerId == id);
        }
    }
}
