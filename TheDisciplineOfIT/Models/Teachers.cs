using System;
using System.ComponentModel.DataAnnotations;

namespace TheDisciplineOfIT.Models
{
    public class Teachers
    {
        [Key]
        public string TeacherID;
        public string TeacherName;
        public string TeahcerQualification;
    }
}
