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

        public ICollection<Students> StudentID { get; set; }
        public ICollection<Resources> ResourceName { get; set; }

        public Request(ICollection<Students> studentid)
        {
            StudentID = studentid;
        }

        public Request(ICollection<Resources> resourceName)
        {
            ResourceName = resourceName;
        }
    }
}
