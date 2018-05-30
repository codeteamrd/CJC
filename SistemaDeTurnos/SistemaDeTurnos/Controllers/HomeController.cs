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
            ViewData["Message"] = "";

            return View();
                
        }

        public IActionResult estatus()
        {
            ViewData["Message"] = "";

            return View();

           }

        public IActionResult Editar_Estatus()
        {
            ViewData["Message"] = "";

            return View();

        }

        public IActionResult RegistroEstatus()
        {
            ViewData["Message"] = "";

            return View();

        }

        public IActionResult DetallesEstatus()
        {
            ViewData["Message"] = "";

            return View();

        }

        public IActionResult menu()
        {
            ViewData["Message"] = "";

            return View();

        }

        public IActionResult menuDos()
        {
            ViewData["Message"] = "";

            return View();

        }

        public IActionResult historial()
        {
            ViewData["Message"] = "";

            return View();

        }

        public IActionResult cajaAsegurado()
        {
            ViewData["Message"] = "";

            return View();

        }

        public IActionResult loginAdmin()
        {
            ViewData["Message"] = "";

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
