using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teoguide.Domain.Model.Request
{
    public class DescripcionReq
    {
        [Required(ErrorMessage = "El Id de CentroHistorico no puede ser Nulo")]
        public int CentroHistoricoId { get; set; }

        [Required(ErrorMessage = "El Idioma no debe ser Nulo")]
        public string Idioma { get; set; }

        [Required(ErrorMessage = "El Texto no debe ser Nulo")]
        public string Texto { get; set; }
    }
}
