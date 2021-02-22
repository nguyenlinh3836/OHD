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
        public Employee Employee { get; set; }  
        public Customer Customer { get; set; }       

    }
}
