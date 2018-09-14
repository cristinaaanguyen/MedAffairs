using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MedicalAffairsSample.Models
{
    public class DBContext : DbContext
    {
        public DbSet<BusinessUnit> BusinessUnits { get; set; } //dbcontext now aware of BusinessUnit class
        public DbSet<Category> Categories { get; set; }
        public DbSet<EducationGrant> EducationGrants { get; set; }
        public DbSet<ResearchGrant> ResearchGrants { get; set; }

    }
}