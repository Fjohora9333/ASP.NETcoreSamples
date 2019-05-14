using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Consulting.Models;
using Microsoft.AspNetCore.Http;

/// <summary>
/// /Fatima Final Practice 2019
/// </summary>
namespace Consulting.Controllers
{
    public class WorkSessionController : Controller
    {
        private readonly ConsultingContext _context;

        public WorkSessionController(ConsultingContext context)
        {
            _context = context;
        }

        // GET: WorkSession
        public async Task<IActionResult> Index(int ContractId, string CompanyName)
        {
            //create current Worksession to use to get total houre

            var currentWorkSession = _context.WorkSession
                                    .Include(ws => ws.Consultant)
                                    .Include(ws => ws.Contract)
                                    .Where(ws => ws.ContractId == ContractId)
                                    .AsQueryable();
            float totalHoure = 0;
            foreach (var workSession in currentWorkSession)
            {
                totalHoure += (float)workSession.HoursWorked;
            }
            string TotalHours = totalHoure.ToString();

            if (ContractId != 0)
            {
                HttpContext.Session.SetInt32(nameof(ContractId), ContractId);
                HttpContext.Session.SetString(nameof(CompanyName), string.IsNullOrEmpty(CompanyName) ? await GetCompanyName(ContractId) : CompanyName);
                HttpContext.Session.SetString(nameof(TotalHours), TotalHours);

            }
            else if (HttpContext.Session.GetInt32("ContractId") != null)
            {
                ContractId =(int)HttpContext.Session.GetInt32(nameof(ContractId));
                CompanyName = HttpContext.Session.GetString(nameof(CompanyName));
                TotalHours = HttpContext.Session.GetString(nameof(TotalHours));
            }
            else
            {
                TempData["message"] = "Please select a Contract";
                return RedirectToAction("Index", "Contract");
            }

            var consultingContext = _context.WorkSession
                                    .Include(w => w.Contract)
                                    .Where(w=>w.ContractId==ContractId);
            return View(await consultingContext.ToListAsync());
        }
        public async Task<string> GetCompanyName(int ContractId)
        {
            //var companyName = _context.Contract
            //                .Include(c => c.Customer)
            //                .Where(c => c.ContractId == ContractId)
            //                .Select(c => c.Customer.CompanyName)
            //                .SingleOrDefaultAsync();
            var companyName = _context.Contract
                .Include(c => c.Customer)
                .Where(c => c.ContractId == ContractId)
                .Select(c => c.Customer.CompanyName)
                .SingleOrDefaultAsync();
            return await companyName;
        }

        // GET: WorkSession/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workSession = await _context.WorkSession
                .Include(w => w.Consultant)
                .Include(w => w.Contract)
                .FirstOrDefaultAsync(m => m.WorkSessionId == id);
            if (workSession == null)
            {
                return NotFound();
            }

            return View(workSession);
        }

        // GET: WorkSession/Create
        public IActionResult Create()
        {
           
            
            ViewData["ConsultantId"] = new SelectList(_context.Consultant, "ConsultantId", "FirstName");
            ViewData["ContractId"] = new SelectList(_context.Contract, "ContractId", "Name");
            return View();
        }

        // POST: WorkSession/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WorkSessionId,ContractId,DateWorked,ConsultantId,HoursWorked,WorkDescription,HourlyRate,ProvincialTax,TotalChargeBeforeTax")] WorkSession workSession)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    WorkSession thisWorkSession = workSession;

                    double hoursWorked = thisWorkSession.HoursWorked;

                    var consultantId = thisWorkSession.ConsultantId;

                    double hourlyRate =await _context.Consultant
                                    .Where(c => c.ConsultantId == consultantId)
                                    .Select(c => c.HourlyRate)
                                    .SingleOrDefaultAsync();

                    thisWorkSession.HourlyRate = hourlyRate;

                    thisWorkSession.TotalChargeBeforeTax = hoursWorked * hourlyRate;

                    //var ContractId = HttpContext.Session.GetInt32("ContractId");
                    var ContractId = thisWorkSession.ContractId;

                    double taxRate = await _context.Contract
                                .Include(c => c.Customer)
                                .Include(c => c.Customer.ProvinceCodeNavigation)
                                .Where(c => c.ContractId == ContractId)
                                .Select(c => c.Customer.ProvinceCodeNavigation.ProvincialTax)
                                .SingleOrDefaultAsync();

                    //var taxRate = _context.Customer
                    //            .Include(c => c.ProvinceCodeNavigation)
                    //            .Select(c => c.ProvinceCodeNavigation.ProvincialTax)
                    //            .FirstOrDefault();

                    thisWorkSession.ProvincialTax = thisWorkSession.TotalChargeBeforeTax * taxRate;

                    _context.Add(thisWorkSession);
                    TempData["message"] = "WorkSession created successfully";

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                ViewData["ConsultantId"] = new SelectList(_context.Consultant, "ConsultantId", "FirstName", workSession.ConsultantId);
                ViewData["ContractId"] = new SelectList(_context.Contract, "ContractId", "Name", workSession.ContractId);
                
            }
            catch(Exception ex)
            {
                TempData["message"] = $"Error creating new workSession: {ex.GetBaseException().Message}";
                //return RedirectToAction("Index");
                ViewData["ConsultantId"] = new SelectList(_context.Consultant, "ConsultantId", "FirstName", workSession.ConsultantId);
                ViewData["ContractId"] = new SelectList(_context.Contract, "ContractId", "Name", workSession.ContractId);
                return View(workSession);
            }
            ViewData["ConsultantId"] = new SelectList(_context.Consultant, "ConsultantId", "FirstName", workSession.ConsultantId);
            ViewData["ContractId"] = new SelectList(_context.Contract, "ContractId", "Name", workSession.ContractId);

            return View(workSession);
        }

        // GET: WorkSession/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workSession = await _context.WorkSession.FindAsync(id);
            if (workSession == null)
            {
                return NotFound();
            }
            ViewData["ConsultantId"] = new SelectList(_context.Consultant, "ConsultantId", "FirstName", workSession.ConsultantId);
            ViewData["ContractId"] = new SelectList(_context.Contract, "ContractId", "Name", workSession.ContractId);
            return View(workSession);
        }

        // POST: WorkSession/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WorkSessionId,ContractId,DateWorked,ConsultantId,HoursWorked,WorkDescription,HourlyRate,ProvincialTax,TotalChargeBeforeTax")] WorkSession workSession)
        {
            if (id != workSession.WorkSessionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    WorkSession thisWorkSession = workSession;
                    //var thisWorkSessionHourlyRate = await _context.Consultant
                    //                               .Where(c => c.ConsultantId == thisWorkSession.ConsultantId)
                    //                               .Select(c => c.HourlyRate)
                    //                               .SingleOrDefaultAsync();

                    //thisWorkSession.HourlyRate = thisWorkSessionHourlyRate;

                    _context.Update(thisWorkSession);
                    TempData["message"] = "WorkSession edited successfully";

                    await _context.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    if (!WorkSessionExists(workSession.WorkSessionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        TempData["message"] = "Exception editing WorkSession " + ex.GetBaseException().Message;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConsultantId"] = new SelectList(_context.Consultant, "ConsultantId", "FirstName", workSession.ConsultantId);
            ViewData["ContractId"] = new SelectList(_context.Contract, "ContractId", "Name", workSession.ContractId);
            return View(workSession);
        }

        // GET: WorkSession/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workSession = await _context.WorkSession
                .Include(w => w.Consultant)
                .Include(w => w.Contract)
                .FirstOrDefaultAsync(m => m.WorkSessionId == id);
            if (workSession == null)
            {
                return NotFound();
            }

            return View(workSession);
        }

        // POST: WorkSession/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var workSession = await _context.WorkSession.FindAsync(id);
                _context.WorkSession.Remove(workSession);
                TempData["message"] = "Delete successfull";
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["message"] = "Error deleting WorkSession :" + ex.GetBaseException().Message;
            }
            return RedirectToAction("Delete");
           
        }

        private bool WorkSessionExists(int id)
        {
            return _context.WorkSession.Any(e => e.WorkSessionId == id);
        }
    }
}
