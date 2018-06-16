using SistemaDeTurnos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace SistemaDeTurnos.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string NumeroAsegurado { get; set; }
        public string Credencial { get; set; }
    }
}
