using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OHD.Models;

namespace OHD.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the OHDUser class
    public class OHDUser : IdentityUser
    {
        public int CustomerId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Gender { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Address { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Contact { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string State { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Country { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        public string RequestorID { get; set; }
        public string AssigneeID { get; set; }
        public ICollection<Request> Request { get; set; }

    }
}
