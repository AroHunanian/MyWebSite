using Microsoft.AspNetCore.Mvc;
using MyWebSite.Models;

namespace MyWebSite.Controllers;

    public class AccountController : Controller
    {
        public IUser user { get; private set; }
        public AccountController(IUser user)
        {
            this.user = user;
        }

        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUp(User user)
        {
        if (ModelState.IsValid)
        {
          
        }
            return View(user);
        }
    }

