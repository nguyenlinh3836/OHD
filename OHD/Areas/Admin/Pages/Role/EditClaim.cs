using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OHD.Areas.Admin.Pages.Role
{
    public class EditClaim
    {
        public int Id { set; get; }
        public string ClaimType { set; get; }
        public string ClaimValue { set; get; }
    }
}
