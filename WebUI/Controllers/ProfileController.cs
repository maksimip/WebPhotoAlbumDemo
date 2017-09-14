using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entitis;
using Domain.Abstract;

namespace WebUI.Controllers
{
    public class ProfileController : Controller
    {
        private IUserRepository repository;

        public ProfileController(IUserRepository repositoryParam)
        {
            this.repository = repositoryParam;
        }
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }
        

        [HttpGet]
        public ActionResult EditProfile(string email)
        {
            User user = repository.Users.Select(u => u).Where(u => u.Email == email).First();
            return View(user);
        }

        [HttpPost]
        public ActionResult SaveProfile(User user)
        {
            repository.SaveUser(user);
            return RedirectToAction("Index", "Profile", new { name = user.FirstName});
        }
    }
}