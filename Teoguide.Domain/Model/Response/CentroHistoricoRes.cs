using System;
using System.Collections.Generic;
using System.Text;

namespace Teoguide.Domain.Model.Response
{
    public class CentroHistoricoRes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImgUrl { get; set; }
    }
}
