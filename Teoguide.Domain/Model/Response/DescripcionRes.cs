using System;
using System.Collections.Generic;
using System.Text;

namespace Teoguide.Domain.Model.Response
{
    public class DescripcionRes
    {
        public int Id { get; set; }
        public int CentroHistoricoId { get; set; }
        public string Texto { get; set; }
    }
}
