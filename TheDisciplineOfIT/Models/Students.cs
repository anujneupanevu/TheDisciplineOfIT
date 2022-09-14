using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheDisciplineOfIT.Models;

namespace TheDisciplineOfIT.Models
{
    public class Students : Person
    {
        [Key]
        public int StudentID { get; set; }

        public ICollection<Courses> Courses { get; set; }
    }
}