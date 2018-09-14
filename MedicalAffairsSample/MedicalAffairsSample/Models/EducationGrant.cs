using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MedicalAffairsSample.Models
{
    public class EducationGrant
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Grant name.")]
        [StringLength(255)]
        public string Name { get; set; }
        private List<string> _Links { get; set; }

        
        public List<string> Links { get { return _Links; } set { _Links = value; } } //use in application to add and remove links

        //the value saved in database is a string and will populate list after the entity is materialized
        public string LinksAsString {

            get { return String.Join(",", _Links); }
            set { _Links = value.Split(',').ToList(); }

        }


        public BusinessUnit BusinessUnit { get; set; } //navigation property, b/c we can navi from one type to another (navi from grant to its BusinessUnit)
        public byte BusinessUnitId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        public EducationGrant()
        {
            //Name = "name1";

            _Links = new List<string>
            {
                "Link1-1",
                "Link2-1"

            };


        }

    }
}