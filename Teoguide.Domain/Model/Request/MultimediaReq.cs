using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teoguide.Domain.Model.Request
{
    public class MultimediaReq
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El Id de CentroHistorico es requerido")]
        public int CentroHistoricoId { get; set; }

        [Required(ErrorMessage ="El Tipo no puede ser Nulo")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El ContenidoUrl no puede ser Nulo")]
        public string ContendioUrl { get; set; }

    }
}
