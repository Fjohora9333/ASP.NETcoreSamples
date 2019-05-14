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
    public class AFSVarietyController : Controller
    {
        private readonly OECContext _context;

        public AFSVarietyController(OECContext context)
        {
            _context = context;
        }

        // GET: AFSVariety
        public async Task<IActionResult> Index(int? CropId )
        {
            int currentCropId = 0;
            string currentCropName = "";

            //If there’s no cropId in the cookie or session variables either, return to 
            //the XXCrop controller with a message asking them to select a crop to see 
            //its varieties.
            //CropId is not coming from URL
            if (CropId == null)  
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("SCropId")))  //CropId Exists in the session
                {
                    currentCropId = int.Parse(HttpContext.Session.GetString("SCropId"));
                    
                }
                else
                {
                    TempData["message"] = "Please select a crop..";
                    return RedirectToAction("Index", "AFSCrop");
                }
                   
            }
            //CropId coming from URL
            else
            {
                currentCropId = (int)CropId;
                //add session variable
                HttpContext.Session.SetString("SCropId", currentCropId.ToString());
                
            }

            currentCropName = _context.Variety
                            .Where(v => v.CropId == currentCropId)
                            .Select(v => v.Crop.Name)
                            .FirstOrDefault();

            HttpContext.Session.SetString("SCropName", currentCropName);

            //add Name from session to ViewBag objects
            ViewBag.Name = HttpContext.Session.GetString("SCropName");
           

            var AFSOECContext = _context.Variety
                .Where(v => v.CropId == currentCropId)
                .ToListAsync();
            return View(await AFSOECContext);
        }

        // GET: AFSVariety/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variety = await _context.Variety
                .Include(v => v.Crop)
                .FirstOrDefaultAsync(m => m.VarietyId == id);
            if (variety == null)
            {
                return NotFound();
            }
            //add Name from session to ViewBag objects
            ViewBag.Name = HttpContext.Session.GetString("SCropName");
            return View(variety);
        }

        // GET: AFSVariety/Create
        public IActionResult Create()
        {
            ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId");
            //add Name from session to ViewBag objects
            ViewBag.Name = HttpContext.Session.GetString("SCropName");
            return View();
        }

        // POST: AFSVariety/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VarietyId,CropId,Name")] Variety variety)
        {
            if (ModelState.IsValid)
            {
                _context.Add(variety);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId", variety.CropId);
            //add Name from session to ViewBag objects
            ViewBag.Name = HttpContext.Session.GetString("SCropName");
            return View(variety);
        }

        // GET: AFSVariety/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variety = await _context.Variety.FindAsync(id);
            if (variety == null)
            {
                return NotFound();
            }
            ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId", variety.CropId);
            //add Name from session to ViewBag objects
            ViewBag.Name = HttpContext.Session.GetString("SCropName");
            return View(variety);
        }

        // POST: AFSVariety/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VarietyId,CropId,Name")] Variety variety)
        {
            if (id != variety.VarietyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(variety);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VarietyExists(variety.VarietyId))
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
            ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId", variety.CropId);
            //add Name from session to ViewBag objects
            ViewBag.Name = HttpContext.Session.GetString("SCropName");
            return View(variety);
        }

        // GET: AFSVariety/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variety = await _context.Variety
                .Include(v => v.Crop)
                .FirstOrDefaultAsync(m => m.VarietyId == id);
            if (variety == null)
            {
                return NotFound();
            }

            //add Name from session to ViewBag objects
            ViewBag.Name = HttpContext.Session.GetString("SCropName");
            return View(variety);
        }

        // POST: AFSVariety/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var variety = await _context.Variety.FindAsync(id);
            _context.Variety.Remove(variety);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VarietyExists(int id)
        {
            return _context.Variety.Any(e => e.VarietyId == id);
        }
    }
}
