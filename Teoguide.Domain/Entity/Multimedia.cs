using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Teoguide.Domain.Entity
{
    public class Multimedia
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        [Required]
        public int CentroHistoricoId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Tipo { get; set; }
        public bool Verificado { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string ContendioUrl { get; set; }

    }
}
