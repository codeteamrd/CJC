using System;
using SistemaDeTurnos.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeTurnos.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
         
         [StringLength(60, MinimumLength = 3)]
          [Required]
        public string Nombres { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
         [Required]
        public string Apellidos { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
         [Required]
        public string Cedula { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
         [Required]
        public string NumeroAsegurado { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
         [Required]
        public string Credencial { get; set; }
    }
}
