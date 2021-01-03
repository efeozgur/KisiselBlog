using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KisiselBlog.Models.context;

namespace KisiselBlog.Controllers
{
    public class MainController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            var model = db.Yazilar.ToList();
            return View(model);
        }
    }
}