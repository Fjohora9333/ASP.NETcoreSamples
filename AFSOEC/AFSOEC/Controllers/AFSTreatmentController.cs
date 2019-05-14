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
    public class AFSTreatmentController : Controller
    {
        private readonly OECContext _context;

        public AFSTreatmentController(OECContext context)
        {
            _context = context;
        }

        // GET: AFSTreatment
        public async Task<IActionResult> Index(int PlotId, int FarmId)
        {
            int CurrentPlotId =PlotId;
           // int CurrentFarmId;


            //if (PlotId!=0)
            //{
            //    CurrentPlotId = PlotId;
            //}
            //else
            //{
            //    CurrentPlotId =(int) HttpContext.Session.GetInt32("CurrentPlotId");
            //}

            if (CurrentPlotId == 0)
            {
                CurrentPlotId =(int) HttpContext.Session.GetInt32("CurrentPlotId");
            }

            HttpContext.Session.SetInt32(nameof(CurrentPlotId), CurrentPlotId);

            var farmId = _context.Treatment
                        .Include(t => t.Plot)
                        .Where(t => t.Plot.PlotId == CurrentPlotId)
                        .Select(t => t.Plot.FarmId)
                        .FirstOrDefault();
            HttpContext.Session.SetInt32(nameof(FarmId), FarmId);
            //if (FarmId!=0)
            //{
            //    CurrentFarmId = FarmId;
            //}
            //else
            //{
            //    CurrentFarmId = (int)HttpContext.Session.GetInt32("FarmId");
            //}

            //var FarmName = _context.Plot
            //             .Include(p => p.Farm)
            //             .Where(p => p.FarmId == FarmId)
            //             .Select(p => p.Farm.Name)
            //             .FirstOrDefault();
            var FarmName = _context.Treatment
                            .Include(p => p.Plot.Farm)
                            .Where(p => p.Plot.FarmId == farmId)
                            .Select(p => p.Plot.Farm.Name)
                            .FirstOrDefault();


           HttpContext.Session.SetString(nameof(FarmName), FarmName);
           ViewBag.FarmName = HttpContext.Session.GetString("FarmName");

            var oECContext = _context.Treatment
                            .Include(t => t.Plot)
                            .Where(t => t.PlotId == CurrentPlotId)
                            .Include(t=>t.TreatmentFertilizer);

            //var TreatmentId = _context.Treatment.Include(t => t.TreatmentFertilizer).Where(t => t.PlotId == PlotId);
            //var TraetmentName = _context.TreatmentFertilizer
            //                    .Include(tf => tf.FertilizerName)
            //                    .Where(tf => tf.TreatmentId == int.Parse(TreatmentId.ToString()));
           
            return View(await oECContext.ToListAsync());
        }

        // GET: AFSTreatment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.FarmName = HttpContext.Session.GetString("FarmName");

            if (id == null)
            {
                return NotFound();
            }

            var treatment = await _context.Treatment
                .Include(t => t.Plot)
                .FirstOrDefaultAsync(m => m.TreatmentId == id);
            if (treatment == null)
            {
                return NotFound();
            }

            return View(treatment);
        }

        // GET: AFSTreatment/Create
        public IActionResult Create()
        {
            ViewBag.FarmName = HttpContext.Session.GetString("FarmName");

            int PlotId =(int) HttpContext.Session.GetInt32("CurrentPlotId");
            HttpContext.Session.SetInt32(nameof(PlotId), PlotId);


            ViewData["PlotId"] = new SelectList(_context.Plot.Where(p=>p.PlotId==PlotId), "PlotId", "PlotId");
            return View();
        }

        // POST: AFSTreatment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TreatmentId,Name,PlotId,Moisture,Yield,Weight")] Treatment treatment)
        {
            Treatment thisTreatment = treatment;
        
            int PlotId = thisTreatment.PlotId;
            //var FarmId = _context.Treatment
            //            .Include(t => t.Plot)
            //            .Where(t => t.Plot.PlotId == thisTreatment.PlotId)
            //            .Select(t => t.Plot.FarmId)
            //            .FirstOrDefault();

            //var FarmName = _context.Treatment
            //                .Include(p => p.Plot.Farm)
            //                .Where(p => p.Plot.FarmId == FarmId)
            //                .Select(p => p.Plot.Farm.Name)
            //                .FirstOrDefault();

            HttpContext.Session.SetInt32(nameof(PlotId), PlotId);
           // HttpContext.Session.SetString(nameof(FarmName), FarmName);
            ViewBag.FarmName = HttpContext.Session.GetString("FarmName");

            if (ModelState.IsValid)
            {
                _context.Add(treatment);
                TempData["Message"] = "Treatment for " + HttpContext.Session.GetString("FarmName") + " is created successfully";

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlotId"] = new SelectList(_context.Plot, "PlotId", "PlotId", treatment.PlotId);
            return View(treatment);
        }

        // GET: AFSTreatment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //ViewBag.FarmName = HttpContext.Session.GetString("FarmName");
            if (id == null)
            {
                return NotFound();
            }

            var treatment = await _context.Treatment.FindAsync(id);
            if (treatment == null)
            {
                return NotFound();
            }
            ViewData["PlotId"] = new SelectList(_context.Plot, "PlotId", "PlotId", treatment.PlotId);
            return View(treatment);
        }

        // POST: AFSTreatment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TreatmentId,Name,PlotId,Moisture,Yield,Weight")] Treatment treatment)
        {
            string currentFarmName = HttpContext.Session.GetString("FarmName");
            ViewBag.FarmName = currentFarmName;
            if (id != treatment.TreatmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(treatment);
                    TempData["Message"] = $"Treatment for farm {currentFarmName} Updated successfully";

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TreatmentExists(treatment.TreatmentId))
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
            ViewData["PlotId"] = new SelectList(_context.Plot, "PlotId", "PlotId", treatment.PlotId);
            return View(treatment);
        }

        // GET: AFSTreatment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewBag.FarmName = HttpContext.Session.GetString("FarmName");
            if (id == null)
            {
                return NotFound();
            }

            var treatment = await _context.Treatment
                .Include(t => t.Plot)
                .FirstOrDefaultAsync(m => m.TreatmentId == id);
            if (treatment == null)
            {
                return NotFound();
            }

            return View(treatment);
        }

        // POST: AFSTreatment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           string currentFarmName = HttpContext.Session.GetString("FarmName");
            var treatment = await _context.Treatment.FindAsync(id);
            _context.Treatment.Remove(treatment);
            TempData["Message"] = $"Trearment for farm {currentFarmName} is deleted successfully";
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TreatmentExists(int id)
        {
            return _context.Treatment.Any(e => e.TreatmentId == id);
        }
    }
}
