using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aerithium.Models;

namespace Aerithium.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AerithiumDB1Entities db = new AerithiumDB1Entities();

            List<ClassesViewModel> model = new List<ClassesViewModel>();
            foreach(Classes @class in db.Classes.ToList())
            {
                model.Add(new ClassesViewModel { class_id = @class.class_id, name = @class.name, description = @class.description });
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch!";

            return View();
        }
    }
}