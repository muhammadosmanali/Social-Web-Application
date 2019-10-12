using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Holara.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Holara.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class FriendRequestController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FriendRequestController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ViewBag.messege = TempData["Messege"];
            var request = _db.Friends.Include(c => c.ApplicationUser1).Where(u => u.User2Id == claim.Value).Where(c => c.IsConfirmed == false).ToList();

            return View(request);
        }

        public async Task<IActionResult> UserDetail(string id)
        {
            var user = await _db.ApplicationUsers.FindAsync(id);
            return View(user);
        }

        public async Task<IActionResult> AcceptRequest(int id)
        {
            var request = await _db.Friends.FindAsync(id);
            TempData["Messege"] = "Successfull Accepted Request";
            request.IsConfirmed = true;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}