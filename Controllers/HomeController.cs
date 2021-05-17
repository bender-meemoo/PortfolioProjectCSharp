using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortfolioProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return Redirect("Home");
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            return View("Home");
        }

        [HttpGet("projects")]
        public IActionResult Projects()
        {
            ViewBag.ListProject = _context.Projects
            .OrderByDescending(c =>c.CreatedAt)
            .ToList();

            return View("Projects");
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }   
}
