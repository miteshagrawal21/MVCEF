using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEF.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
    }

    public partial class EmployeeMetaData
    {
        [Required]
        public string DOB { get; set; }
        [Required]
        [Display(Name ="Department")]
        public int Department_Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }

        //public virtual Department Department { get; set; }
    }
}