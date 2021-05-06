using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teoguide.Domain.Model.Request
{
    public class CentroHistoricoReq
    {
        [Required(ErrorMessage ="El Nombre no puede ser Nulo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Direccion no puede ser Nulo")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La Latitud no puede ser Nulo")]
        public string Latitud { get; set; }

        [Required(ErrorMessage = "La Longitud no puede ser Nulo")]
        public string Longitud { get; set; }

        public List<MultimediaReq> Multimedias { get; set; }
        public List<DescripcionReq> Descripciones { get; set; }
    }
}
