using Microsoft.AspNetCore.Identity;
using OHD.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Column(TypeName = "varchar(50)")]    
        public string Gender { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Address { get; set; }

        public Facility Facility { get; set; }
        public string OHDID { get; set; }
        public OHDUser OHDUser { get; set; }

    }
}
