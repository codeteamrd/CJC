using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTurnos.Models;
//
using SistemaDeTurnos.Controllers;

namespace SistemaDeTurnos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            /*la vaina*/
        }

        public IActionResult loginAdmin()
        {
            return View();
        }
        
        public IActionResult credencial()
        {
            ViewData[""] = "";

            return View();
                
        }

        public IActionResult estatus()
        {
            ViewData[""] = "";

            return View();

        }

        public IActionResult menu()
        {
            ViewData[""] = "";

            return View();

        }

        public IActionResult menuDos()
        {
            ViewData[""] = "";

            return View();

        }

        public IActionResult historial()
        {
            ViewData[""] = "";

            return View();

        }

        
        public IActionResult asegurado()
        {
            ViewData[""] = "Your asegurado page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
