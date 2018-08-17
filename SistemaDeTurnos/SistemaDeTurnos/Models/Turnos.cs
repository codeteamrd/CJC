using SistemaDeTurnos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace SistemaDeTurnos.Models
{
    public class Turnos
    {
        public int Id { get; set; }
        //public string Ticket { get; set; }
        public bool Seguro { get; set; }
        public string Estatus { get; set; }
        public bool Estado { get; set; }
        public string Area  { get; set; }
        public DateTime Fecha { get; set; }
        public string Ticket { get; internal set; }
    }
}
