using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class SectionController : Controller
    {
        //
        // GET: /Section/

        public ActionResult Index(int id)
        {
            AppContext epContext = new AppContext();
            List<Section> sections = epContext.Sections.Where(s => s.SubjectId == id).ToList();
            TempData["Id"] = id;
            return View(sections);
        }

        public ActionResult Create(int Id)
        {
            SectionViewModel model = new SectionViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(SectionViewModel section)
        {
            AppContext epContext = new AppContext();
            Section s = new Section
            {
                SubjectId = section.SelectedSubject,
                SectionName = section.SectionName,
                Description = section.Description
            };
            epContext.Sections.Add(s);
            epContext.SaveChanges();
            return View();
        }

        public ActionResult AddQuestions(int id)
        {
            TempData["SectionId"] = id;
            return RedirectToAction("Create", "Question", TempData);
        }
    }
}
