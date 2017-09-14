using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entitis;
using Domain.Abstract;
using Domain.Concrete;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserRepository repository;

        public AccountController(IUserRepository repositoryParam)
        {
            this.repository = repositoryParam;
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User userParam)
        {
            if (ModelState.IsValid)
            {
                User user = repository.Users.Select(u => u).Where(u => u.Email == userParam.Email).First();
                

                if (user.Pass == userParam.Pass)
                {
                    
                    return RedirectToAction("Index", "Profile", new { name = user.FirstName, email = user.Email });
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect email or password");
                    return View("Index");
                }
            }
            else
                return View("Index");
            
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            bool state = repository.AddUser(user);
            if (state)
            {
                return RedirectToAction("Index", "Profile", new { name = user.FirstName, email = user.Email });
            }
            else
            {
                ModelState.AddModelError("", "User with so Email already is exist.");
                return View("Index");
            }
        }
    }
}