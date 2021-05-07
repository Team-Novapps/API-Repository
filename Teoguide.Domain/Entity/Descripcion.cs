using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Teoguide.Domain.Entity
{
    public class Descripcion
    {
        public int Id { get; set; }

        [Required]
        public int CentroHistoricoId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Idioma { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Texto { get; set; }

    }
}
