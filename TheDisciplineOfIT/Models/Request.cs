using System;
using System.ComponentModel.DataAnnotations;

namespace TheDisciplineOfIT.Models
{
    public class Request
    {
        [Key]
        public string RequestID;
        public DateTime Date;
        public DateTime Time;
        public string Status;
    }
}
