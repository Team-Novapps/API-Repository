using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teoguide.Domain.Model.Request
{
    public class PlanReq
    {
        [Required(ErrorMessage = "El Titulo no puede ser Nulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La Descripcion no puede ser Nulo")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Id de Usuario no puede ser Nulo")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "La Fecha del plan no puede ser Nulo")]
        public DateTime FechaPlan { get; set; }

        //[Required (ErrorMessage = "La Actividades no pueden ser Nulo")]
        public List<ActividadReq> Actividades { get; set; }
    }
}
