using MedicalAffairsSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicalAffairsSample.ViewModels;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace MedicalAffairsSample.Controllers
{
    public class AdminPanelController : Controller
    {
        private DBContext _context;
        public AdminPanelController()
        {

            _context = new DBContext(); //intialize private variable; this DB context is a disposable opbject

        }


        // GET: AdminPanelViewModel

        public ActionResult Index()
        {
            var viewModel = new AdminPanelViewModel { BusinessUnits = _context.BusinessUnits.ToList(),
                                                      EducationGrants = _context.EducationGrants.ToList()};

            return View(viewModel);
        }

        public ActionResult EditBusinessUnit( int id ) {

            var businessunit = _context.BusinessUnits.SingleOrDefault(b => id == b.Id);
            if (businessunit == null) return HttpNotFound();
            return View("BusinessUnitForm",businessunit);



        }

        public ActionResult AddBusinessUnit() {

            var businessunit = new BusinessUnit();
            return View("BusinessUnitForm", businessunit);

        }

        public ActionResult DeleteBusinessUnit(int id)
        {
            var businessunit = _context.BusinessUnits.Find(id);
            if (businessunit == null) return HttpNotFound();

            _context.BusinessUnits.Remove(businessunit);
            _context.SaveChanges();
            return RedirectToAction("Index", "AdminPanel");

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveBusinessUnit(BusinessUnit businessUnit) {

            if (!ModelState.IsValid)
            {
                var businessunit = new BusinessUnit
                {
                    //Id = businessUnit.Id,
                    Name = businessUnit.Name,
                    Description = businessUnit.Description
                };

                return View("BusinessUnitForm", businessunit);
            }

            if (businessUnit.Id == 0)
            { //when id is 0, that means we have a new business unit
                _context.BusinessUnits.Add(businessUnit);

            }
            else {
                var businessUnitInDb = _context.BusinessUnits.Single(b => b.Id == businessUnit.Id);
                businessUnitInDb.Id = businessUnit.Id;
                businessUnitInDb.Name = businessUnit.Name;
                businessUnitInDb.Description = businessUnit.Description;
                businessUnitInDb.InfoLink = businessUnit.InfoLink;

            }

            try
            {
                _context.SaveChanges();

            }

            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
                foreach (var validationErrors in e.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }

            return RedirectToAction("Index", "AdminPanel");




        }
    }
}