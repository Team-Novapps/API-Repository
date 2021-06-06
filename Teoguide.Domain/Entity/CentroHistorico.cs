using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Teoguide.Domain.Entity
{
    public class CentroHistorico
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Direccion { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Latitud { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Longitud { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string ImgUrl { get; set; }

        public List<Multimedia> Multimedias { get; set; }
        public List<Descripcion> Descripciones { get; set; }     
    }
}
