using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OHD.Data;

namespace OHD.Areas.Admin.Pages.Role
{
    public class AdminModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly OHDContext _context;

        public AdminModel(RoleManager<IdentityRole> roleManager, OHDContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }
        public List<IdentityRole> roles { set; get; }

        [BindProperty(SupportsGet = true)]
        public string roleid { set; get; }

        public IdentityRole role { set; get; }

        [TempData] 
        public string StatusMessage { get; set; }
         public IList<EditClaim> claims { get;set; }

        public async Task<IActionResult> OnGet()
        {
            roles = await _roleManager.Roles.ToListAsync();
            return Page();
        }
    }
}
