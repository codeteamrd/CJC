using System;
using SistemaDeTurnos.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeTurnos.Data
{
    public class SistemaDeTurnosContex : DbContext
    {
        public SistemaDeTurnosContex(DbContextOptions<SistemaDeTurnosContex> options) : base(options)
        {
        }

        public DbSet<Turnos> Turnos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<UsuarioAdmin> UsuarioAdmin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turnos>().ToTable("Turnos");
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<UsuarioAdmin>().ToTable("UsuarioAdmin");
            
        }

    } 

 }
   

