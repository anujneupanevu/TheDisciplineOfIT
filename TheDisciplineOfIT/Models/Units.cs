using System;
using System.ComponentModel.DataAnnotations;
using TheDisciplineOfIT.Models;
using System.Collections.Generic;

namespace TheDisciplineOfIT.Models
{
    public class Units
    {
        [Key]
        public string UnitID { get; set; }
        public string UnitName { get; set; }

        public ICollection<Teachers> Teachers { get; set; }
    }
}
