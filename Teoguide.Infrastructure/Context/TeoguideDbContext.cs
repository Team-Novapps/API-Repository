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
           var usuario1 = new Usuario
            {
                Id = 1,
                Nombres = "Natalia",
                Apellidos = "Ramirez Castro",
                Correo = "natalia.ramirez@gmail.com",
                Contrasenya = "123456",
                ImagenUrl = "https://i.imgur.com/Bvwppza.png",
                Tipo = "TURISTA_LOCAL"                
            };

            var usuario2 = new Usuario
            {
                Id = 2,
                Nombres = "Veronica",
                Apellidos = "Lovera Tarazona",
                Correo = "vero.lovera@gmail.com",
                Contrasenya = "123456",
                ImagenUrl = "https://i.imgur.com/K6GcFKt.png",
                Tipo = "TURISTA_LOCAL"
            };
            var usuario3 = new Usuario
            {
                Id = 3,
                Nombres = "Melody",
                Apellidos = "Salgado Perez",
                Correo = "lody.salgado@gmail.com",
                Contrasenya = "123456",
                ImagenUrl = "https://i.imgur.com/gtBtZhC.png",
                Tipo = "TURISTA_LOCAL"
            };
            var usuario4 = new Usuario
            {
                Id = 4,
                Nombres = "Mateo",
                Apellidos = "Castro Gutierrez",
                Correo = "mateo.castro@gmail.com",
                Contrasenya = "123456",
                ImagenUrl = "https://i.imgur.com/juP6DaG.png",
                Tipo = "TURISTA_LOCAL"
            };
            var usuario5 = new Usuario
            {
                Id = 5,
                Nombres = "Albedo",
                Apellidos = "Buenaventura Puertas",
                Correo = "albedo.puertas@gmail.com",
                Contrasenya = "123456",
                ImagenUrl = "https://i.imgur.com/LcnD5hf.png",
                Tipo = "TURISTA_LOCAL"
            };
            var usuario6 = new Usuario
            {
                Id = 6,
                Nombres = "Jorge",
                Apellidos = "Aquino Perez",
                Correo = "Jorge.aquino@gmail.com",
                Contrasenya = "123456",
                ImagenUrl = "https://i.imgur.com/juP6DaG.png",
                Tipo = "TURISTA_LOCAL"
            };          

            var ch_caral = new CentroHistorico
            {
                Id = 1,
                Nombre = "Caral",
                Direccion = "Acceso Caral, Caral 15161",
                ImgUrl = "https://i.imgur.com/FPfbY3Y.jpg",
                Latitud = "-10.892196046322377",                
                Longitud = "-77.52333687113237",
            };

            var ch_huallamarca = new CentroHistorico
            {
                Id = 2,
                Nombre = "Huaca Huallamarca",
                Direccion = "Esquina con avenida El Rosario y, Av. Nicolas de Rivera 201, San Isidro",
                ImgUrl = "https://i.imgur.com/Ql68krK.jpg",
                Latitud = "-12.097147060919646",
                Longitud = "-77.04048228878406",
            };

            var ch_mateo_salado = new CentroHistorico
            {
                Id = 3,
                Nombre = "Huaca Mateo-Salado",
                Direccion = "Talavera, Cercado de Lima 15083",
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

            var comentario1 = new Comentario
            {
                Id = 1,
                UsuarioId = 1,
                CentroHistoricoId = 1,
                Texto = "Luego de visitar Caral puedes darte una vuelta al valle de Supe no te arrepentirás"
            };

            var comentario2 = new Comentario
            {
                Id = 2,
                UsuarioId = 2,
                CentroHistoricoId = 1,
                Texto = "Impresionante lugar, los guías turísticos fueron muy pacientes al enseñar sobre Caral"
            };

            var comentario3 = new Comentario
            {
                Id = 3,
                UsuarioId = 4,
                CentroHistoricoId = 1,
                Texto = "Recomendadísimo este sitio arqueológico para visitar y aprender más de nuestro Perú"
            };

            var comentario4 = new Comentario
            {
                Id = 4,
                UsuarioId = 5,
                CentroHistoricoId = 1,
                Texto = "Algo cansado el viaje para llegar a Caral, pero las ruinas, la historia y el paisaje del valle de supe hacen que valga la pena"
            };

            var comentario5 = new Comentario
            {
                Id = 5,
                UsuarioId = 3,
                CentroHistoricoId = 2,
                Texto = "Un destino turístico interesante en el mismo centro de la ciudad de Lima, genial!"
            };

            var comentario6 = new Comentario
            {
                Id = 6,
                UsuarioId = 6,
                CentroHistoricoId = 3,
                Texto = "Pense que sería solo unas pequeñas ruinas, pero me equivoqué, este lugar es impresionante!!"
            };

            builder.Entity<Usuario>().HasData(new List<Usuario> { usuario1, usuario2, usuario3, usuario4, usuario5, usuario6});
            builder.Entity<CentroHistorico>().HasData(new List<CentroHistorico> { ch_caral, ch_huallamarca, ch_mateo_salado });
            builder.Entity<Descripcion>().HasData(new List<Descripcion> { descp_caral, descp_huallamarca, descp_mateo_salado });
            builder.Entity<Comentario>().HasData(new List<Comentario> { comentario1, comentario2, comentario3, comentario4, comentario5, comentario6 });
            //builder.Entity<Plan>().HasData(plan);
            //builder.Entity<Actividad>().HasData(new List<Actividad> { actividad_uno, actividad_dos });
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
