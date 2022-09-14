using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheDisciplineOfIT.Models
{
    public class Students
    {
        [Key]
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Courses> Courses { get; set; }

        public Students(ICollection<Courses> courses)
        {
            Courses = courses;
        }
    }
}
