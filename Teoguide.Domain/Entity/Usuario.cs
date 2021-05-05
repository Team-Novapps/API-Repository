using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Teoguide.Domain.Entity
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Nombres { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Apellidos { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Correo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Contrasenya { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string ImagenUrl { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Tipo { get; set; }
    }
}
