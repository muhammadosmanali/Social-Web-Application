using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Holara.Data;
using Holara.Models;
using Holara.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;

namespace Holara.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;

        public ProfileController(ApplicationDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
        }


        public async Task<IActionResult> Index()
        {
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ViewBag.messege = TempData["Messege"];
            var userProfile =await _db.ApplicationUsers.FindAsync(claim.Value);
            return View(userProfile);
        }

        //Get: Edit
        public async Task<IActionResult> Edit()
        {
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var user = await _db.ApplicationUsers.FindAsync(claim.Value);
            return View(user);
        }

        //Post: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ApplicationUser applicationUser)
        {
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                var user = await _db.ApplicationUsers.FindAsync(claim.Value);
                user.Name = applicationUser.Name;
                user.UserName = applicationUser.UserName;
                user.Email = applicationUser.Email;
                user.PhoneNumber = applicationUser.PhoneNumber;

                //Saving Image
                var webrootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                
                if(files.Count > 0 && files[0] != null)
                {
                    var upload = Path.Combine(webrootPath, SD.UserImageFolder);
                    var new_extension = Path.GetExtension(files[0].FileName);
                    var old_extension = Path.GetExtension(user.Image);

                    if(System.IO.File.Exists(Path.Combine(upload, user.Id + old_extension)))
                    {
                        System.IO.File.Delete(Path.Combine(upload, user.Id + old_extension));
                    }

                    using (var fileStream = new FileStream(Path.Combine(upload, user.Id + new_extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    applicationUser.Image = @"\" + SD.UserImageFolder + @"\" + user.Id + new_extension;
                }
                if(applicationUser.Image != null)
                {
                    user.Image = applicationUser.Image;
                }
                TempData["Messege"] = "Profile Updated Successfully";
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicationUser);
        }
    }
}