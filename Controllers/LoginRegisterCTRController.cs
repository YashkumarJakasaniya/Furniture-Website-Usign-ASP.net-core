using FURNITURE.Data;
using FURNITURE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace FURNITURE.Controllers
{
    public class LoginRegisterCTRController : Controller
    {
        public LoginRegisterDbContext DbContext;

        public LoginRegisterCTRController(LoginRegisterDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {

                return RedirectToAction("Index","Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserTbl user)
        {
            var myuser = DbContext.User_tbl.Where(x => x.UserEmail == user.UserEmail && x.Password == user.Password).FirstOrDefault();
            if (myuser != null)
            {
                HttpContext.Session.SetString("UserSession", myuser.UserEmail);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Message = "login failed";
            }

            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }

            return View();
        }
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserTbl user)
        {
            if (ModelState.IsValid)
            {

                await DbContext.User_tbl.AddAsync(user);
                await DbContext.SaveChangesAsync();
                TempData["success"] = "successfully registered";
                return RedirectToAction("Login");

            }
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
