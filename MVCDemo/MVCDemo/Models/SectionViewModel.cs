using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Models
{
    public class SectionViewModel
    {
        public string SectionName { get; set; }
        public string Description { get; set; }
        public IEnumerable<SelectListItem> SubjectDropDown
        {
            get
            {
                //var allFlavors = _organizationService.GetOrganizations().Select(x =>
                AppContext apContext = new AppContext();
                var allFlavors = apContext.Subjects.Select(x =>
                new SelectListItem
                {
                    Value = x.SubjectId.ToString(),
                    Text = x.Name
                });
                return allFlavors;
            }
        }
        public int SelectedSubject { get; set; }
    }
}