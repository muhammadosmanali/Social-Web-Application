using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Holara.Data;
using Holara.Models;
using Holara.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Holara.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class FriendsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FriendsController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var applicationUsers = _db.ApplicationUsers.Where(m => m.Id != claim.Value).ToList();

            return View(applicationUsers);
        }

        public async Task<IActionResult> ConfirmRequest(string id)
        {
            var friend = await _db.ApplicationUsers.FindAsync(id);
            var friends = new FriendsViewModel
            {
                applicationUser = await _db.ApplicationUsers.FindAsync(id),
                friends =  _db.Friends.ToList()
        };
            return View(friends);
        }

        [HttpPost, ActionName("ConfirmRequest")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmRequestPost(string id)
        {
            ClaimsPrincipal currentUser = User;
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string requestSender = claim.Value;
            string requestAceptor = id;
            var presentDate = DateTime.Now;

            TempData["Messege"] = "Successfully send request to ";
            var friends = new Friends();
            friends.User1Id = requestSender;
            friends.User2Id = requestAceptor;
            friends.RequestDate = presentDate;
            friends.IsConfirmed = false;

            _db.Friends.Add(friends);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(UserDetail), new { @id=id });
        }

        public async Task<IActionResult> UserDetail(string id)
        {
            ViewBag.messege = TempData["Messege"];
            var user = await _db.ApplicationUsers.FindAsync(id);
            return View(user);
        }

        public async Task<IActionResult> CancelRequest(int id)
        {
            var request = await _db.Friends.FindAsync(id);
            _db.Friends.Remove(request);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}