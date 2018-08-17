using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaDeTurnos.Data;
using SistemaDeTurnos.Models;

namespace SistemaDeTurnos.Controllers
{
    public class AdminController : Controller
    {
 
        

        public IActionResult inicio()
        {
            return View();
        }

        public IActionResult cajaAsegurado()
        {
            ViewData[""] = "";

            return View();

        }

         public IActionResult controlMedico()
        {
            ViewData[""] = "";

            return View();

        }
        
        public IActionResult historialDiario()
        {
            ViewData[""] = "";

            return View();

        }
        
        public IActionResult historial()
        {
            ViewData[""] = "";

            return View();

        }

    }

}
        