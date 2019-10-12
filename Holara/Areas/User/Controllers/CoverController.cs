using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Holara.Data;
using Holara.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Holara.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class CoverController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CoverController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //Get Current User Id
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            //Get the Friend List of current User
            var friendlist = _db.Friends
                .Include(u => u.ApplicationUser1)
                .Include(u => u.ApplicationUser2)
                .Where(x => (x.User1Id == claim.Value || x.User2Id == claim.Value))
                .Where(x => x.IsConfirmed)
                .ToList();

            //Create new List of Posts
            var posts = new List<Post>();

            //Get List of Post of Every Friend of Current User
            foreach (var item in friendlist)
            {   
                if(item.User1Id == claim.Value)
                {
                    var postList = _db.Posts.Include(u => u.User).Where(x => x.UserId == item.User2Id).Where(x => x.IsPublicOrNot).ToList();
                    posts.AddRange(postList);
                }
                else if(item.User2Id == claim.Value)
                {
                    var postList = _db.Posts.Include(u => u.User).Where(x => x.UserId == item.User1Id).Where(x => x.IsPublicOrNot).ToList();
                    posts.AddRange(postList);
                }
            }

            //Get the post of Current User
            var currentuserPosts = _db.Posts.Include(u => u.User).Where(u => u.UserId == claim.Value).ToList();

            //Add Current User Post List to new List
            posts.AddRange(currentuserPosts);

            //Order by Date and time of Post 
            var postsList = posts.OrderByDescending(x => x.PostDateAndTime).ToList();
            return View(postsList);
        }
    }
}