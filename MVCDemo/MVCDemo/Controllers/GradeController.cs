using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class GradeController : Controller
    {
        //
        // GET: /Grade/

        public ActionResult Index()
        {
            AppContext epContext = new AppContext();
            List<Grade> g = epContext.Grades.ToList();
            return View(g);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Grade grade)
        {
            AppContext epContext = new AppContext();
            epContext.Grades.Add(grade);
            epContext.SaveChanges();

            List<Grade> g = epContext.Grades.ToList();
            return View("Index",g);
        }
    }
}
