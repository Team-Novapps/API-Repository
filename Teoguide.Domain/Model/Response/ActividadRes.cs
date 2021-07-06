using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teoguide.Domain.Model.Response
{
    public class ActividadRes
    {
        public int Id { get; set; }

        public int PlanId { get; set; }

        public int CentroHistoricoId { get; set; }
       
        public string NombreCentroHistorico { get; set; }

        //[DisplayFormat(DataFormatString = "{hh:mm tt}", ApplyFormatInEditMode = true)]
        public string HoraActividad { get; set; }

        public string Descripcion { get; set; }
    }
}
