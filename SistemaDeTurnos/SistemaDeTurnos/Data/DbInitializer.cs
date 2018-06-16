using SistemaDeTurnos.Models;
using System;
using System.Linq;

namespace SistemaDeTurnos.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SistemaDeTurnosContex context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.UsuarioAdmin.Any())
            {
                return;   // DB has been seeded
            }

            var usuarioAdmin = new UsuarioAdmin[]
            {
            new UsuarioAdmin{Nombres="joel",Apellidos="jesus",NombreUsuario="joeljesusmot@gmail.com",Contraseña="123"},
            };

            foreach (UsuarioAdmin s in usuarioAdmin)
            {
                context.UsuarioAdmin.Add(s);
            }
            context.SaveChanges();

            var usuarios = new Usuarios[]
            {
            new Usuarios{Nombres="celso",Apellidos="abad",Cedula="12345678",NumeroAsegurado="134",Credencial="68754"},
            };

            foreach (Usuarios c in usuarios)
            {
                context.Usuarios.Add(c);
            }
            context.SaveChanges();

            var turnos = new Turnos[]
            {
            new Turnos{Ticket="1",Seguro=true,Estatus="VIP",Estado=true,Area="laboratorio",},
            };
            foreach (Turnos e in turnos)
            {
                context.Turnos.Add(e);
            }
            context.SaveChanges();
        }
    }
}