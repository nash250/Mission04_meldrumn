using Microsoft.AspNetCore.Mvc;
using MyFirstASPNETWEBAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Controller Program
namespace MyFirstASPNETWEBAPP.Controllers
{
    // Public class for controller
    public class BlahController : Controller
    {
        // Controller to return view for index page
        public IActionResult Index()
        {
            return View();
        }

        // Get method for Calc Page
        [HttpGet]
        public IActionResult GradeCalc()
        {
            return View();
        }

        // Post method for Calc Page
        [HttpPost]
        public IActionResult GradeCalc (GradeCalcModel model)
        {
            return View();
        }

    }
}
