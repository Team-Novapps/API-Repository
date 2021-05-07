using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teoguide.Domain.Model.Request
{
    public class ComentarioReq
    {
        [Required(ErrorMessage ="El Id de Usuario no puede ser Nulo")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El Id de CentroHistorico no puede ser Nulo")]
        public int CentroHistoricoId { get; set; }

        [Required(ErrorMessage = "El Texto no puede ser Nulo")]
        public string Texto { get; set; }
    }
}
