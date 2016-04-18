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
            SubjectViewModel model = new SubjectViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(SubjectViewModel subject)
        {
            AppContext epContext = new AppContext();
            Subject s = new Subject
            {
                GradeId = subject.SelectedGrade,
                Name = subject.Name,
                Description = subject.Description
            };
            epContext.Subjects.Add(s);
            epContext.SaveChanges();

            return RedirectToAction("Index", "Section", new { id = s.SubjectId });
        }
    }
}
