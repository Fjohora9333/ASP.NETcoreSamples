using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubUI.Models;
using Microsoft.AspNetCore.Http;

namespace ClubUI.Controllers
{
    public class ContractController : Controller
    {
        private readonly ClubsContext _context;

        public ContractController(ClubsContext context)
        {
            _context = context;
        }

        // GET: Contract
        public async Task<IActionResult> Index(int? ClubId)
        {
            int currentClubId = 0;
            string currentClubName = "";
            //if ClubId dosen't exist in the URL
            if (ClubId==null)
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("SesClubId")))
                {
                    currentClubId =int.Parse( HttpContext.Session.GetString("SesClubId"));
                }
                //if ClubId dosen't exist in the URL and Session Variable
                else
                {
                    TempData["Message"] = "No Club is selected, Please select a Club..";
                    return RedirectToAction("Index", "Club");
                }
            }
            //if ClubId exists in the URL
            else
            {
                currentClubId =(int)ClubId;
                HttpContext.Session.SetString("SesClubId", currentClubId.ToString());
            }
            currentClubName = _context.Contract
                            .Include(c => c.Club)
                            .Where(c => c.Club.ClubId == currentClubId)
                            .Select(c => c.Club.Name)
                            .FirstOrDefault();
            //Adding Current club Name in the session 
            HttpContext.Session.SetString("SesClubName", currentClubName);
            //Adding Current club Name in the Viewbag to send it ti the view 
            ViewBag.ClubName = HttpContext.Session.GetString("SesClubName");
            //calculate total price
            //double totalPrice = _context.Contract
            //                   .Where(c => c.ClubId == currentClubId)
            //                   .Sum(c => c.PricePerPerformace * c.NumberOfPerformances);
            var totalPrice = _context.Contract.Select(c => c.PricePerPerformace*c.NumberOfPerformances);

            var clubsContext = _context.Contract
                            .Include(c => c.Club)
                            .Include(c => c.Group)
                            .Where(c=>c.ClubId==currentClubId)
                            .OrderByDescending(c=>c.StartDate);
            return View(await clubsContext.ToListAsync());
        }

        // GET: Contract/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract
                .Include(c => c.Club)
                .Include(c => c.Group)
                .FirstOrDefaultAsync(m => m.ContractId == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }

        // GET: Contract/Create
        public IActionResult Create()
        {
            //Getting the clibId from seddion
            int ClubId =int.Parse( HttpContext.Session.GetString("SesClubId"));
           //int currentStyleCode=_context.C
            //Adding Current club Name in the Viewbag to send it to the view 
            ViewBag.ClubName = HttpContext.Session.GetString("SesClubName");

            ViewData["ClubId"] = new SelectList(_context.Club, "ClubId", "Name");
            ViewData["GroupId"] = new SelectList(_context.Groups
                , "GroupId", "Name");
            return View();
        }

        // POST: Contract/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContractId,StartDate,GroupId,ClubId,PricePerPerformace,NumberOfPerformances")] Contract contract)
        {
            //Getting the clibId from session
            int ClubId = int.Parse(HttpContext.Session.GetString("SesClubId"));

            //Adding Current club Name in the Viewbag to send it ti the view 
            ViewBag.ClubName = HttpContext.Session.GetString("SesClubName");
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(contract);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = "Contract added succeccfully";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.GetBaseException().Message);
            }


            ViewData["ClubId"] = new SelectList(_context.Club, "ClubId", "Name", contract.ClubId);
            ViewData["GroupId"] = new SelectList(_context.Groups, "GroupId", "Name", contract.GroupId);
            return View(contract);
        }

        // GET: Contract/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Adding Current club Name in the Viewbag to send it ti the view 

            ViewBag.ClubName = HttpContext.Session.GetString("SesClubName");
            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract.FindAsync(id);
            if (contract == null)
            {
                return NotFound();
            }
            ViewData["ClubId"] = new SelectList(_context.Club, "ClubId", "Name", contract.ClubId);
            ViewData["GroupId"] = new SelectList(_context.Groups, "GroupId", "Name", contract.GroupId);
            return View(contract);
        }

        // POST: Contract/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContractId,StartDate,GroupId,ClubId,PricePerPerformace,NumberOfPerformances,TotalPrice")] Contract contract)
        {
            //Adding Current club Name in the Viewbag to send it ti the view 

            ViewBag.ClubName = HttpContext.Session.GetString("SesClubName");

            if (id != contract.ContractId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contract);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractExists(contract.ContractId))
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
            ViewData["ClubId"] = new SelectList(_context.Club, "ClubId", "Name", contract.ClubId);
            ViewData["GroupId"] = new SelectList(_context.Groups, "GroupId", "Name", contract.GroupId);
            return View(contract);
        }

        // GET: Contract/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Adding Current club Name in the Viewbag to send it ti the view 

            ViewBag.ClubName = HttpContext.Session.GetString("SesClubName");

            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract
                .Include(c => c.Club)
                .Include(c => c.Group)
                .FirstOrDefaultAsync(m => m.ContractId == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }

        // POST: Contract/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contract = await _context.Contract.FindAsync(id);
            _context.Contract.Remove(contract);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractExists(int id)
        {
            return _context.Contract.Any(e => e.ContractId == id);
        }
    }
}
