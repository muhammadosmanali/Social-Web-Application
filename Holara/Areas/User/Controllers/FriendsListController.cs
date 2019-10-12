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
    public class FriendsListController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FriendsListController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ViewBag.messege = TempData["Message"];
            var friendlist = _db.Friends.Where(x => (x.User1Id == claim.Value || x.User2Id == claim.Value)).Include(u => u.ApplicationUser1).Include(u => u.ApplicationUser2).ToList();
            return View(friendlist);
        }

        public async Task<IActionResult> UserDetail(string id)
        {
            var user = await _db.ApplicationUsers.FindAsync(id);
            return View(user);
        }

        public async Task<IActionResult> UnFriend(int id)
        {
            var friend = await _db.Friends.FindAsync(id);
            TempData["Message"] = "Unfriend Successfully";

            _db.Friends.Remove(friend);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}