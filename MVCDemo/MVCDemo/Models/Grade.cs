using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("tblGrade")]
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}