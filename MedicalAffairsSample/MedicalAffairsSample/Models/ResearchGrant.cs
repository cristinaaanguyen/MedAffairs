using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalAffairsSample.Models
{
    public class ResearchGrant
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Grant name.")]
        [StringLength(255)]
        public Dictionary<string, string> Links { get; set; }
        public BusinessUnit BusinessUnit { get; set; } //navigation property, b/c we can navi from one type to another (navi from customer to its membership type)
        public byte BusinessUnitId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

    }
}