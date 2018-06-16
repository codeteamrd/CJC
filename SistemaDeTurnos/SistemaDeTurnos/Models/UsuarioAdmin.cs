using SistemaDeTurnos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace SistemaDeTurnos.Models
{
    public class UsuarioAdmin
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario  { get; set; }
        public string Contraseña { get; set; }
    }
    
}
