using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalAffairsSample.Models;


namespace MedicalAffairsSample.ViewModels
{
    public class AdminPanelViewModel
    {
        public List<BusinessUnit> BusinessUnits { get; set; }
        public List<EducationGrant> EducationGrants { get; set; }
    }
}