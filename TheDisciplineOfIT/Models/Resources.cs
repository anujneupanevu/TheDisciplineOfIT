using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TheDisciplineOfIT.Models
{
    public class Resources
    {
        [Key]
        public string ResourceID { get; set; }
        public string ResourceName { get; set; }
        public int ResourceValue { get; set; }
        public int ResourceQuantity { get; set; }

        public ICollection<Units> Units { get; set; }
    }
}
