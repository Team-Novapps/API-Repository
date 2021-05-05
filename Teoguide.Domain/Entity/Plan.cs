﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Teoguide.Domain.Entity
{
    public class Plan
    {
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Titulo { get; set; }

        public List<Actividad> Actividades { get; set; }
    }
}
