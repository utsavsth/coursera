using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class SubjectController : Controller
    {
        //
        // GET: /Subject/

        public ActionResult Index()
        {
            AppContext epContext = new AppContext();
            List<Subject> subjects = epContext.Subjects.ToList();

            return View(subjects);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Subject subject)
        {
            AppContext epContext = new AppContext();
            epContext.Subjects.Add(subject);
            epContext.SaveChanges();

            return RedirectToAction("Index", "Section", new { id = subject.SubjectId });
        }
    }
}
