using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TheDisciplineOfIT.Models
{
    public class Teachers
    {
        [Key]
        public string TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeahcerQualification { get; set; }

        public ICollection<Units> Units { get; set; }
    }
}
