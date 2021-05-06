using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Teoguide.Domain.Entity
{
    public class Comentario
    {
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int CentroHistoricoId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Texto { get; set; }

        public Usuario Usuario { get; set; }
        
    }
}
