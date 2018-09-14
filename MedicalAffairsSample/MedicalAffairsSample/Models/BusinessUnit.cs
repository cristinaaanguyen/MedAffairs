using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedicalAffairsSample.Models
{
    public class BusinessUnit
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        [Required(ErrorMessage = "Please enter Business Unit's name.")]
        [StringLength(255)] //data annotations to overrwrite default conventions; every time we make changes to domain models, must add migration in PM
        public string Name { get; set; }
        public string Description { get; set; }
        public string InfoLink { get; set; }





    }
}