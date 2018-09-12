using MedicalAffairsSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalAffairsSample.Controllers
{
    public class MedicalAffairsController : Controller
    {
        // GET: MedicalAffairs
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult MedicalAffairsView()
        {

            return View();
        }
    }
}