using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;
using voleyballapp.webui.Identity;
using voleyballapp.webui.Models;

namespace voleyballapp.webui.Controllers
{
    //[Authorize(Roles ="admin")]
    public class AdminController:Controller
    {
        private UserManager<User> _userManager;

        private RoleManager<IdentityRole> _rolemanager;
        public AdminController(UserManager<User> userManager,RoleManager<IdentityRole> rolemanager)
        {
            this._userManager = userManager;
            _rolemanager = rolemanager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }

        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _rolemanager.FindByIdAsync(id);

            var members = new List<User>();
            var nonMembers = new List<User>();

            foreach (var user in _userManager.Users)
            {   
                var list = await _userManager.IsInRoleAsync(user,role.Name)
                                ?members:nonMembers;
                list.Add(user); // mük
            }
            return View(new RoleDetails(){
                Role = role,
                Members = members,
                NonMembers = nonMembers
            });
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            foreach (var userId in model.IdsToAdd??new string[]{})
            {
                var user = await _userManager.FindByIdAsync(userId);
                if(user!=null)
                {
                    var result = await _userManager.AddToRoleAsync(user,model.RoleName);
                    if(!result.Succeeded)
                    {
                        foreach (var error in result.Errors)    
                        {
                            ModelState.AddModelError("",error.Description);
                        }
                    }
                }
            }

            foreach (var userId in model.IdsToDelete??new String[]{})
            {
                var user = await _userManager.FindByIdAsync(userId);
                if(user!=null)
                {
                    var result = await _userManager.RemoveFromRoleAsync(user,model.RoleName);
                    if(!result.Succeeded)
                    {
                        foreach (var error in result.Errors)    
                        {
                            ModelState.AddModelError("",error.Description);
                        }
                    }
                }
            }
            
            return Redirect("/admin/role/"+model.RoleId);


        }
        public IActionResult RoleList()
        {
            return View(_rolemanager.Roles);
        }
        public IActionResult RoleCreate()
        {
            return View();
            
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _rolemanager.CreateAsync(new IdentityRole(model.RoleName));
                if(result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("",error.Description);

                    }
                }
            }
            return View();
            
        }

        
        
    }
}