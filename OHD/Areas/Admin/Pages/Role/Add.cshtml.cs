using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OHD.Areas.Admin.Pages.Role
{
    public class AddModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public AddModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public string StatusMessage { get; set; }
        public class InputModel
        {
            public string ID { set; get; }

            [Required(ErrorMessage = "Must Insert Role Name")]
            [Display(Name = " Role Name")]
            [StringLength(100, ErrorMessage = "{0} lenght {2} to {1} character.", MinimumLength = 3)]
            public string Name { set; get; }

        }
        [BindProperty]
        public InputModel Input { set; get; }

        [BindProperty]
        public bool IsUpdate { set; get; }
        public IActionResult OnGet() => NotFound("Not Found");
        public IActionResult OnPost() => NotFound("Not Found");
        public IActionResult OnPostStartNewRole()
        {
            StatusMessage = "Add information for new Role";
            IsUpdate = false;
            ModelState.Clear();
            return Page();
        }

        public async Task<IActionResult> OnPostStartUpdate()
        {
            StatusMessage = null;
            IsUpdate = true;
            if (Input.ID == null)
            {
                StatusMessage = "Error: Not found information Role";
                return Page();
            }
            var result = await _roleManager.FindByIdAsync(Input.ID);
            if (result != null)
            {
                Input.Name = result.Name;
                ViewData["Title"] = "Update Role : " + Input.Name;
                ModelState.Clear();
            }
            else
            {
                StatusMessage = "Error: Not found information Role ID = " + Input.ID;
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAddOrUpdate()
        {

            if (!ModelState.IsValid)
            {
                StatusMessage = null;
                return Page();
            }

            if (IsUpdate)
            {
                // Update
                if (Input.ID == null)
                {
                    ModelState.Clear();
                    StatusMessage = "Error: Not found information";
                    return Page();
                }
                var result = await _roleManager.FindByIdAsync(Input.ID);
                if (result != null)
                {
                    result.Name = Input.Name;
                    // Update name Role
                    var roleUpdateRs = await _roleManager.UpdateAsync(result);
                    if (roleUpdateRs.Succeeded)
                    {
                        StatusMessage = "Update Role Success";
                    }
                    else
                    {
                        StatusMessage = "Error: ";
                        foreach (var er in roleUpdateRs.Errors)
                        {
                            StatusMessage += er.Description;
                        }
                    }
                }
                else
                {
                    StatusMessage = "Error: Not Found Role";
                }

            }
            else
            {
                
                var newRole = new IdentityRole(Input.Name);
                
                var rsNewRole = await _roleManager.CreateAsync(newRole);
                if (rsNewRole.Succeeded)
                {
                    StatusMessage = $"Add new Role Success: {newRole.Name}";
                    return RedirectToPage("./Index");
                }
                else
                {
                    StatusMessage = "Error: ";
                    foreach (var er in rsNewRole.Errors)
                    {
                        StatusMessage += er.Description;
                    }
                }
            }
            return Page();
        }
    }
    }
