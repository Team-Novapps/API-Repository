using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teoguide.Domain.Model.Request
{
    public class ActividadReq
    {
        [Required(ErrorMessage = "El Id del Centro Historico no puede ser Nulo")]
        public int CentroHistoricoId { get; set; }

        //[Required(ErrorMessage = "La Fecha de Actividad no puede ser Nulo")]
        //[DataType(DataType.Time)]
        public string HoraActividad { get; set; }

        public string Descripcion { get; set; }
    }
}
