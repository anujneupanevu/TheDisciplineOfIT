using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheDisciplineOfIT.Models;

namespace TheDisciplineOfIT.Models
{
    public class Teachers : Person
    {
        [Key]
        public int TeacherID { get; set; }

        public ICollection<Units> Units { get; set; }
    }
}