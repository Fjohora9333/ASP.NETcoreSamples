using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSOEC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AFSOEC.Controllers
{
    public class RemotesController : Controller
    {
        //[Remote("ChecProvinceCode", "Remotes")]
        //public string ProvinceCode { get; set; }

        //connection to the database
        private readonly OECContext _context;

        // GET: Remotes

        public RemotesController(OECContext context)
        {

            _context = context;
        }
        
        public JsonResult ChecProvinceCode(string provinceCode)
        {
            provinceCode = provinceCode.ToLower();
            try
            {
                if (provinceCode.Length != 2)
                {
                    return Json("ProvinceCode shouldbe exactly 2 letters.");
                }
                else
                {
                    var ProvinceCode = _context.Province
                                    .Where(p => p.ProvinceCode == provinceCode)
                                    .Select(p => p.ProvinceCode)
                                    .FirstOrDefault();
                    if (ProvinceCode != null)
                    {
                        return Json(true);
                    }
                    else
                    {
                        return Json("ProvinceCode not found.");

                    }
                }

            }
            catch(Exception ex)
            {
                return Json("Error: " + ex.GetBaseException().Message);
            }
            
            
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