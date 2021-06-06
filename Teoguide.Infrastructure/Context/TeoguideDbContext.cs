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


            var ch_caral = new CentroHistorico
            {
                Id = 1,
                Nombre = "Caral",
                Direccion = "Valle de Supe",
                ImgUrl = "https://i.imgur.com/FPfbY3Y.jpg",
                Latitud = "-10.892196046322377",                
                Longitud = "-77.52333687113237",
            };

            var ch_huallamarca = new CentroHistorico
            {
                Id = 2,
                Nombre = "Huaca Huallamarca",
                Direccion = "Lima",
                ImgUrl = "https://i.imgur.com/Ql68krK.jpg",
                Latitud = "-12.097147060919646",
                Longitud = "-77.04048228878406",
            };

            var ch_mateo_salado = new CentroHistorico
            {
                Id = 3,
                Nombre = "Huaca Mateo-Salado",
                Direccion = "Lima",
                ImgUrl = "https://i.imgur.com/u8IRRd1.jpg",
                Latitud = "-12.067163839786117",
                Longitud = "-77.06362247344228",
            };

            var descp_caral = new Descripcion
            { 
                Id = 1,
                CentroHistoricoId = 1,
                Idioma = "ESP",
                Texto = "La Ciudad Sagrada de Caral es un interesante sitio arqueológico ubicado en el Valle de Supe."
            };

            var descp_huallamarca = new Descripcion
            {
                Id = 2,
                CentroHistoricoId = 2,
                Idioma = "ESP",
                Texto = "Considerada como un centro ceremorial, tiene la forma de una pirámide trunca con tres plataformas superpuestas."
            };

            var descp_mateo_salado = new Descripcion
            {
                Id = 3,
                CentroHistoricoId = 3,
                Idioma = "ESP",
                Texto = "El complejo arqueológico de Mateo Salado está constituido por cinco montículos piramidales."
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
            builder.Entity<CentroHistorico>().HasData(new List<CentroHistorico> { ch_caral, ch_huallamarca, ch_mateo_salado });
            builder.Entity<Descripcion>().HasData(new List<Descripcion> { descp_caral, descp_huallamarca, descp_mateo_salado });
            builder.Entity<Plan>().HasData(plan);
            builder.Entity<Actividad>().HasData(new List<Actividad> { actividad_uno, actividad_dos });
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<CentroHistorico> CentroHistoricos { get; set; }
        public DbSet<Descripcion> Descripciones { get; set; }
        public DbSet<Multimedia> Multimedias { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
       
    }
}
