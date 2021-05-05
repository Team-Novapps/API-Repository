using System;
using System.Collections.Generic;
using System.Text;

namespace Teoguide.Domain.Model.Response
{
    public class PlanDetail
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public List<ActividadRes> Actividades { get; set; }
    }
}
