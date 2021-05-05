using System;
using System.Collections.Generic;
using System.Text;

namespace Teoguide.Domain.Model.Response
{
    public class ActividadRes
    {
        public int Id { get; set; }

        public int CentroHistoricoId { get; set; }
       
        public string NombreCentroHistorico { get; set; } 

        public DateTime FechaHoraActividad { get; set; }

        public string Descripcion { get; set; }
    }
}
