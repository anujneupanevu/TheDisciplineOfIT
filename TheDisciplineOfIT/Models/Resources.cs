using System;
using System.ComponentModel.DataAnnotations;

namespace TheDisciplineOfIT.Models
{
    public class Resources
    {
        [Key]
        public string ResourceID;
        public string ResourceName;
        public int ResourceValue;
        public int ResourceQuantity;
    }
}
