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
    public class AFSPlotController : Controller
    {
        private readonly OECContext _context;

        // Constants
        // criteria identifiers for session variable
        const string CRITERIA_CROP = "crop";
        const string CRITERIA_VARIETY = "variety";
        const string CRITERIA_PLOT = "plot";

        public AFSPlotController(OECContext context)
        {
            _context = context;
        }

        // GET: AFSPlot
        public async Task<IActionResult> Index(int CropId, string CropName, int VarietyId, string VarietyName, string sortby, int PlotId, string FarmName)
        {
            var oECContext = _context.Plot
                .Include(p => p.Farm)
                .Include(p => p.Variety)
                .ThenInclude(v => v.Crop)
                .Include(p => p.Treatment)
                .AsQueryable();

            // check if a criteria has been persisted
            var criteria = HttpContext.Session.GetString("criteria");
           

        // check if a cropId or varietyId is passed and persist it along with a criteria identifier
            if (CropId != 0 || VarietyId != 0)
            {
            if (CropId != 0)
            {
                HttpContext.Session.SetInt32(nameof(CropId), CropId);
                HttpContext.Session.SetString(nameof(CropName), CropName);
                criteria = CRITERIA_CROP;
            }
            else
            {
                HttpContext.Session.SetInt32(nameof(VarietyId), VarietyId);
                HttpContext.Session.SetString(nameof(VarietyName), VarietyName);
                criteria = CRITERIA_VARIETY;
            }

           // HttpContext.Session.SetString(nameof(criteria), criteria);
            }
            else if (PlotId != 0)
            {
                HttpContext.Session.SetInt32(nameof(PlotId), PlotId);
                HttpContext.Session.SetString(nameof(FarmName), FarmName);
                criteria = CRITERIA_PLOT;

            }
            HttpContext.Session.SetString(nameof(criteria), criteria);


            // restrict the listing to plots with persisted criteria
            switch (criteria)
            {
                case CRITERIA_CROP:

                    oECContext = oECContext
                        .Where(p => p.Variety.CropId == HttpContext.Session.GetInt32(nameof(CropId)));
                    break;
                case CRITERIA_VARIETY:
                    oECContext = oECContext
                        .Where(p => p.VarietyId == (int)HttpContext.Session.GetInt32(nameof(VarietyId)));
                    break;
                case CRITERIA_PLOT:
                    oECContext = oECContext
                        .Where(p => p.PlotId == HttpContext.Session.GetInt32(nameof(PlotId)));
                    break;
                default:
                    oECContext = _context.Plot;
                    break;
            }

            // order the listing by selected column heading
            switch (sortby)
            {
                case "farm":
                    oECContext = oECContext.OrderBy(p => p.Farm.Name).ThenByDescending(p => p.DatePlanted);
                    break;
                case "variety":
                    oECContext = oECContext.OrderBy(p => p.Variety.Name).ThenByDescending(p => p.DatePlanted);
                    break;
                case "cec":
                    oECContext = oECContext.OrderBy(p => p.Cec).ThenByDescending(p => p.DatePlanted);
                    break;
                default:
                    oECContext = oECContext.OrderByDescending(p => p.DatePlanted);
                    break;
            }

            return View(await oECContext.ToListAsync());

        }

        // GET: AFSPlot/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plot
                .Include(p => p.Farm)
                .Include(p => p.Variety)
                .FirstOrDefaultAsync(m => m.PlotId == id);
            if (plot == null)
            {
                return NotFound();
            }

            return View(plot);
        }

        // GET: AFSPlot/Create
        public IActionResult Create()
        {
            var varietyList = new SelectList(_context.Variety.OrderBy(v => v.Name), "VarietyId", "Name");

            if (HttpContext.Session.GetString("criteria") == CRITERIA_CROP)
                // if the filter criteria was cropId, filter the drop-down to just varieties of that crop
                varietyList = new SelectList(_context.Variety.Where(v => v.CropId == (int)HttpContext.Session.GetInt32("cropId")).OrderBy(v => v.Name), "VarietyId", "Name");
            else
                // if the filter criteria was varietyId, default the drop-down to that value
                varietyList = new SelectList(_context.Variety.OrderBy(v => v.Name), "VarietyId", "Name", HttpContext.Session.GetInt32("varietyId"));

            ViewData["FarmId"] = new SelectList(_context.Farm.OrderBy(f => f.Name), "FarmId", "Name");
            ViewData["VarietyId"] = varietyList;
            return View();
        }

        // POST: AFSPlot/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlotId,FarmId,VarietyId,DatePlanted,DateHarvested,PlantingRate,PlantingRateByPounds,RowWidth,PatternRepeats,OrganicMatter,BicarbP,Potassium,Magnesium,Calcium,PHsoil,PHbuffer,Cec,PercentBaseSaturationK,PercentBaseSaturationMg,PercentBaseSaturationCa,PercentBaseSaturationH,Comments")] Plot plot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["FarmId"] = new SelectList(_context.Farm.OrderBy(f => f.Name), "FarmId", "Name", plot.FarmId);

            if (HttpContext.Session.GetString("criteria") == CRITERIA_CROP)
                // if the filter criteria was cropId, filter the drop-down to just varieties of that crop
                ViewData["VarietyId"] = new SelectList(_context.Variety.Where(v => v.CropId == (int)HttpContext.Session.GetInt32("CropId")).OrderBy(v => v.Name), "VarietyId", "Name", plot.VarietyId);
            else
                ViewData["VarietyId"] = new SelectList(_context.Variety.OrderBy(v => v.Name), "VarietyId", "Name", plot.VarietyId);
            return View(plot);
        }

        // GET: AFSPlot/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plot.FindAsync(id);
            if (plot == null)
            {
                return NotFound();
            }
            ViewData["FarmId"] = new SelectList(_context.Farm.OrderBy(f => f.Name), "FarmId", "Name", plot.FarmId);
            ViewData["VarietyId"] = new SelectList(_context.Variety.OrderBy(v => v.Name), "VarietyId", "Name", plot.VarietyId);
            return View(plot);
        }

        // POST: AFSPlot/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlotId,FarmId,VarietyId,DatePlanted,DateHarvested,PlantingRate,PlantingRateByPounds,RowWidth,PatternRepeats,OrganicMatter,BicarbP,Potassium,Magnesium,Calcium,PHsoil,PHbuffer,Cec,PercentBaseSaturationK,PercentBaseSaturationMg,PercentBaseSaturationCa,PercentBaseSaturationH,Comments")] Plot plot)
        {
            if (id != plot.PlotId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlotExists(plot.PlotId))
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
            ViewData["FarmId"] = new SelectList(_context.Farm.OrderBy(f => f.Name), "FarmId", "Name", plot.FarmId);
            ViewData["VarietyId"] = new SelectList(_context.Variety.OrderBy(v => v.Name), "VarietyId", "Name", plot.VarietyId);
            return View(plot);
        }

        // GET: AFSPlot/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plot
                .Include(p => p.Farm)
                .Include(p => p.Variety)
                .FirstOrDefaultAsync(m => m.PlotId == id);
            if (plot == null)
            {
                return NotFound();
            }

            return View(plot);
        }

        // POST: AFSPlot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plot = await _context.Plot.FindAsync(id);
            _context.Plot.Remove(plot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlotExists(int id)
        {
            return _context.Plot.Any(e => e.PlotId == id);
        }
    }
}
