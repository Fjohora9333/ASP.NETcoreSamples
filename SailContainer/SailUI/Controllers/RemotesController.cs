using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SailUI.Models;

namespace SailUI.Controllers
{
    public class RemotesController : Controller
    {
        //connection to the database
        private readonly SailContext _context;

        // GET: Remotes

        public RemotesController(SailContext context)
        {

            _context = context;
        }
        public JsonResult CheckCapitalName(string Capital,string ProvinceCode)
        {
            //check if the name of the capital exists in the town table
            var capitalTown = _context.Town
                            .Where(t => t.ProvinceCode == ProvinceCode)
                            .Select(t => t.TownName)
                            .SingleOrDefault();

            if (capitalTown!=null && Capital==null)
            {
                return Json($"Capital can not be empty for province {ProvinceCode}");
            }
            //check if the provinceCode exists in the town table
            //var provinceInTown = _context.Town
            //                .Where(t => t.TownName == Capital)
            //                .Select(t => t.ProvinceCode)
            //                .SingleOrDefault();
            //if(provinceInTown!= ProvinceCode)
            //{
            //    return Json($"Not valid Capit name, {Capital} belongs to another Provinve ");
            //}


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