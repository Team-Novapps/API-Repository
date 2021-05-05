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

        // le pones si es requerido o no y su tipo de dato en sql a cada atributo
        // por lo que si va a ser nullable no le pongas [Required]
        //[Required]
        //[Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Latitud { get; set; }

        public string Longitud { get; set; }

        public int DescripcionId { get; set; }

        //public List<Descripcion> Descripciones { get; set; }
        // lo descomentas cuando creas la entidad Descripcion, es para las relaciones       
    }
}
