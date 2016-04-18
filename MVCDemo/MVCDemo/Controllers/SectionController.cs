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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Section section)
        {
            AppContext epContext = new AppContext();
            epContext.Sections.Add(section);
            epContext.SaveChanges();
            return View();
        }
    }
}
