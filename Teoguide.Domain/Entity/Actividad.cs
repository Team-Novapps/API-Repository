using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Teoguide.Domain.Entity
{
    public class Actividad
    {
        public int Id { get; set; }

        [Required]
        public int PlanId { get; set; }

        [Required]
        public int CentroHistoricoId { get; set; }

        [Required]
        [Column(TypeName = "time(0)")]
        public TimeSpan HoraActividad { get; set; }

        public string Descripcion { get; set; }

        public CentroHistorico CentroHistorico { get; set; }
    }
}
