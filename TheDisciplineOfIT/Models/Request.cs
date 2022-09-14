using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheDisciplineOfIT.Models
{
    public class Request
    {
        [Key]
        public string RequestID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }

        public ICollection<Students> Students { get; set; }
        public ICollection<Resources> Resources { get; set; }
    }
}
