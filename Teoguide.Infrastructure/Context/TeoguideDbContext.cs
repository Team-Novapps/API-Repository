using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Teoguide.Domain.Entity;
using System;
using System.Collections.Generic;

namespace Teoguide.Infrastructure.Context
{
    public class TeoguideDbContext : IdentityDbContext
    {
        public TeoguideDbContext(DbContextOptions<TeoguideDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ModelConfig(builder);
            base.OnModelCreating(builder);
        }

        private void ModelConfig(ModelBuilder builder)
        {
            var usuario = new Usuario
            {
                Id = 1,
                Nombres = "Natalia",
                Apellidos = "Ramirez Castro",
                Correo = "natalia.ramirez@gmail.com",
                Contrasenya = "123456",
                ImagenUrl = "url",
                Tipo = "TURISTA_LOCAL"                
            };


            var centro_historico = new CentroHistorico
            {
                Id = 1,
                Nombre = "Caral",
                Direccion = "Valle de Supe",
                Latitud = "12.1238594",
                Longitud = "-36.1598621",
            };

            var plan = new Plan
            {
                Id = 1,
                Titulo = "Visita a Caral",
                UsuarioId = 1
            };

            var actividad_uno = new Actividad
            {
                Id = 1,
                PlanId = 1,
                CentroHistoricoId = 1,
                Descripcion = "Recorrer el lugar",
                FechaHoraActividad = DateTime.Now,                
            };

            var actividad_dos = new Actividad
            {
                Id = 2,
                PlanId = 1,
                CentroHistoricoId = 1,
                Descripcion = "Comer platos tipicos",
                FechaHoraActividad = DateTime.Now,
            };

            builder.Entity<Usuario>().HasData(usuario);
            builder.Entity<CentroHistorico>().HasData(centro_historico);
            builder.Entity<Plan>().HasData(plan);
            builder.Entity<Actividad>().HasData(new List<Actividad> { actividad_uno, actividad_dos});
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<CentroHistorico> CentroHistoricos { get; set; }
       
    }
}
