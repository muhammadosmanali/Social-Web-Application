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
using Microsoft.EntityFrameworkCore;

namespace Holara.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;


        public PostController(ApplicationDbContext db, HostingEnvironment hostingEnvironment)
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
            var postList = await _db.Posts.Include(u => u.User).Where(u => u.UserId == claim.Value).OrderByDescending(m => m.PostDateAndTime).ToListAsync();
            return View(postList);
        }

        //GET: Create 
        public IActionResult Create()
        {
            return View();
        }

        //Post: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post post)
        {
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            _db.Posts.Add(post);
            await _db.SaveChangesAsync();

            //Saving Image
            var webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var postInDB = await _db.Posts.FindAsync(post.Id);

            if (files.Count != 0)
            {
                var upload = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(upload, post.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                postInDB.Image = @"\" + SD.ImageFolder + @"\" + post.Id + extension;
            }
            postInDB.UserId = claim.Value;
            postInDB.PostDateAndTime = DateTime.Now;
            TempData["Messege"] = "Post Added Successfully";
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Get: Edit
        public async Task<IActionResult> Edit(int id)
        {
            var postInDB = await _db.Posts.FindAsync(id);
            return View(postInDB);
        }

        //Post : Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Post post)
        {
            if(ModelState.IsValid)
            {
                var webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                var postInDB = await _db.Posts.FindAsync(id);
                if(files.Count != 0 && files[0] != null)
                {
                    var upload = Path.Combine(webRootPath, SD.ImageFolder);
                    var old_extension = Path.GetExtension(postInDB.Image);
                    var new_extension = Path.GetExtension(files[0].FileName);
                    if(System.IO.File.Exists(Path.Combine(upload, postInDB.Id + old_extension)))
                    {
                        System.IO.File.Delete(Path.Combine(upload, postInDB.Id + old_extension));
                    }
                    using (var fileStream = new FileStream(Path.Combine(upload, postInDB.Id + new_extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    post.Image = @"\" + SD.ImageFolder + @"\" + postInDB.Id + new_extension;
                }
                if(post.Image != null)
                {
                    postInDB.Image = post.Image;
                }
                postInDB.PostDescription = post.PostDescription;
                postInDB.IsPublicOrNot = post.IsPublicOrNot;
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        //Get: Delete
        public IActionResult Delete(int? id)
        {
            var postInDB = _db.Posts.Find(id);
            return View(postInDB);
        }

        //Post: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var postInDb = await _db.Posts.FindAsync(id);
            if(postInDb == null)
            {
                return NotFound();
            }
            _db.Posts.Remove(postInDb);
            await _db.SaveChangesAsync();
            ViewBag.Messege = "Post Deleted Successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}