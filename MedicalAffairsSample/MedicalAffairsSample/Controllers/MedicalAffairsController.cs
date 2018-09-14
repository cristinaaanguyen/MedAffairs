using MedicalAffairsSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalAffairsSample.Controllers
{
    public class MedicalAffairsController : Controller
    {
        private DBContext _context;
        public MedicalAffairsController() {

            _context = new DBContext();

        }

        // GET: MedicalAffairs
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult MedicalAffairsView()
        {
            var grant = new EducationGrant();
            grant.Name = "name1";
            grant.Description = "description1";
            grant.BusinessUnitId = 3;

            var edugrant = _context.EducationGrants.SingleOrDefault(e => e.Id == 4);
            edugrant.Links.RemoveAt(0);
            
            //edugrant.Links.Add("Link1-3");


            // _context.EducationGrants.Add(grant);

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

            return View();
        }
    }
}