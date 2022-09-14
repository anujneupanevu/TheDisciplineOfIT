using System;
using System.ComponentModel.DataAnnotations;
using TheDisciplineOfIT.Models;
namespace TheDisciplineOfIT.Models
{
    public class Units
    {
        [Key]
        public string UnitID;
        public string UnitName;
        public string teacher;
    }
}
