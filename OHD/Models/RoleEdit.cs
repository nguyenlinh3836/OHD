using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OHD.Areas.Identity.Data;

namespace OHD.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<OHDUser> Members { get; set; }
        public IEnumerable<OHDUser> NonMembers { get; set; }
    }
}
