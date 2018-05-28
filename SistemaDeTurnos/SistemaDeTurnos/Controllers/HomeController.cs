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

        public IActionResult credencial()
        {
            ViewData["Message"] = "klk";

            return View();
                
        }

        public IActionResult VIP()
        {
            ViewData["Message"] = "klk";

            return View();

        }


        public IActionResult estatus()
        {
            ViewData["Message"] = "klk";

            return View();

        }

        public IActionResult menu()
        {
            ViewData["Message"] = "klk";

            return View();

        }

        public IActionResult menuDos()
        {
            ViewData["Message"] = "klk";

            return View();

        }

        public IActionResult historial()
        {
            ViewData["Message"] = "klk";

            return View();

        }

        public IActionResult registroUsuario()
        {
            ViewData["Message"] = "klk";

            return View();

        }

        public IActionResult loginAdmin()
        {
            ViewData["Message"] = "klk";

            return View();

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult asegurado()
        {
            ViewData["Message"] = "Your asegurado page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
