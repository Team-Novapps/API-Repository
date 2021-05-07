using System;
using System.Collections.Generic;
using System.Text;

namespace Teoguide.Domain.Model.Response
{
    public class MultimediaRes
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        //necesito responde con el CEntro historico?,
        //si ya estoy regresando una lista de multimedia en CentroHistorico
        public int CentroHistoricoId { get; set; }
        public string Tipo { get; set; }
        public bool Verificado { get; set; }
        public string ContendioUrl { get; set; }
    }
}
