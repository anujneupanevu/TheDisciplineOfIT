using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheDisciplineOfIT.Controllers
{
    public class RequestController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult Resources()
        {
            return View();
        }
        public IActionResult Teachers()
        {
            return View();
        }
        public IActionResult Units()
        {
            return View();
        }
    }
}
