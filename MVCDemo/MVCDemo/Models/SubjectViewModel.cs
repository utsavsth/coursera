using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Models
{
    public class SubjectViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<SelectListItem> GradeDropDown
        {
            get
            {
                //var allFlavors = _organizationService.GetOrganizations().Select(x =>
                AppContext apContext = new AppContext();
                var allFlavors = apContext.Grades.Select(x =>
                new SelectListItem
                {
                    Value = x.GradeId.ToString(),
                    Text = x.GradeName
                });
                return allFlavors;
            }
        }
        public int SelectedGrade { get; set; }
    }
}