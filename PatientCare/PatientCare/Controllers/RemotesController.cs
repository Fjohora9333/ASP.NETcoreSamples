using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientCare.Models;

namespace PatientCare.Controllers
{
    public class RemotesController : Controller
    {
        private readonly PatientCareContext _context;

        public RemotesController(PatientCareContext context)
        {

            _context = context;
        }

        // GET: Remotes
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult CheckProvinceCode(string ProvinceCode)
        {
            ProvinceCode = ProvinceCode.ToUpper();
            try
            {
                if (ProvinceCode.Length != 2)
                {
                    return Json("ProvinceCode shouldbe exactly 2 letters.");
                }
                else
                {
                    var oECContext = _context.Province
                                    .Where(p => p.ProvinceCode == ProvinceCode)
                                    .Select(p => p.Name)
                                    .FirstOrDefault();
                    if (oECContext != null)
                    {
                        return Json(true);
                    }
                    else
                    {
                        return Json("ProvinceCode not found.");

                    }
                }

            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }

        }
        public JsonResult CheckPhonePattern(string homePhone, string ProvinceCode)
        {
            //if (homePhone != null)
            //{
            //    var countryCode = _context.Province
            //                .Where(p => p.ProvinceCode == ProvinceCode)
            //                .Select(p => p.CountryCode)
            //                .FirstOrDefault();
            //    var phonePattern = _context.Country
            //                .Where(p => p.CountryCode == countryCode)
            //                .Select(p => p.PhonePattern)
            //                .FirstOrDefault();

            //    Regex pattern = new Regex(@"^"+phonePattern+"$", RegexOptions.IgnoreCase);
            
            //    if (pattern.IsMatch(homePhone))
            //    {
            //        return Json(true);
            //    }
            //    else
            //    {
            //        if (countryCode.Trim() == "CA")
            //        {
            //            return Json("Phone pattern should be 999-999-9999");
            //        }
            //        if (countryCode.Trim() == "US")
            //        {
            //            return Json("Phone pattern should be (999) 999-9999");
            //        }
            //    }
            //}
           
            return Json(true);
        }
        public JsonResult CheckPostalCode(string postalCode, string provinceCode)
        {
            if(postalCode != null)
            {
                var countryCode = _context.Province
                                .Where(p => p.ProvinceCode == provinceCode)
                                .Select(p => p.CountryCode)
                                .FirstOrDefault();
                var postalPattern = _context.Country
                                .Where(c => c.CountryCode == countryCode)
                                .Select(c => c.PostalPattern)
                                .FirstOrDefault();
                Regex pattern = new Regex(@"^" + postalPattern + "$", RegexOptions.IgnoreCase);
                if (pattern.IsMatch(postalCode))
                {
                    return Json(true);
                }
                else
                {
                    return Json("Not valid postalCode");
                }

            }
            return Json(true);
        }
        public JsonResult CheckPatientExists(string firstName, string lastName, DateTime dateOfBirth)
        {
            var patient = _context.Patient
                        .Where(p => p.LastName == lastName && p.DateOfBirth == dateOfBirth && p.FirstName == firstName)
                        .Select(p => p.LastName)
                        .FirstOrDefault();
            if(patient == null)
            {
                return Json(true);
            }
            else
            {
                return Json("Patient already exists in the database");
            }
                        
        }
        //    public JsonResult CheckProvinceCode(string)
        //{

        //}


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