using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoAlbumDemo.Models;
using PhotoAlbumDemo.Domain;

namespace PhotoAlbumDemo.Controllers
{
    public class AcountController : Controller
    {
        // GET: Acount
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(User user)
        {
            EFDbContext dbContext = new EFDbContext();
            dbContext.Users.Add(new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                //SurName = null,
                //Age = 25,
                //Country = null,
                Email = user.Email,
                Pass = user.Pass
            });

            dbContext.SaveChanges();

            ViewBag.Name = user.FirstName;
            return View();
        }
    }
}