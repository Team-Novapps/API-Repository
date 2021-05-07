using System;
using System.Collections.Generic;
using System.Text;

namespace Teoguide.Domain.Model.Response
{
    public class ComentarioRes
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CentroHistoricoId { get; set; }
        public string Texto { get; set; }

        //Usuario
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string ImagenUrlUsuario { get; set; }
    }
}
