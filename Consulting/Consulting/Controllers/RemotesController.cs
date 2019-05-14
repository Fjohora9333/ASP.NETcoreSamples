using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consulting.Controllers
{
    public class RemotesController : Controller
    {
        private readonly ConsultingContext _context;

        public RemotesController(ConsultingContext context)
        {
            _context = context;
        }
        public JsonResult CheckDateWorked(DateTime DateWorked, int ContractId)
        {
            var startDate =_context.Contract
                            .Where(c=>c.ContractId==ContractId)
                            .Select(c => c.StartDate)
                            .SingleOrDefault();
            if(startDate > DateWorked)
            {
                return Json("DateWorked can not be before contract startDate.");
            }
            return Json(true);
        }
        // GET: Remotes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Remotes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Remotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Remotes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Remotes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Remotes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Remotes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Remotes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}