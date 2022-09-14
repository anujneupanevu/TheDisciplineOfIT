﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheDisciplineOfIT.Models
{
    public class Courses
    {
        [Key]
        public string CourseID { get; set; }
        public string CourseName { get; set; }

        public ICollection<Units> Units { get; set; }
    }
}
