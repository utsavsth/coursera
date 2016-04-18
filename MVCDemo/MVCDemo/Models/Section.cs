using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("tblSection")]
    public class Section
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public string Description { get; set; }
        public int SubjectId { get; set; }
    }
}