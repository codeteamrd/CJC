using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTurnos.Models;
//
using SistemaDeTurnos.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace SistemaDeTurnos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
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

            return View();

        }

        public IActionResult menu()
        {
            ViewData[""] = "";

            return View();

        }

        public IActionResult opcionesimagenes()
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
            return View();
        }
    
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> asegurado([Bind("seguro")] Turnos turnos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(turnos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(asegurado));
            }
            return View(asegurado);
        }*/


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
