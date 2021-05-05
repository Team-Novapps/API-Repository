using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teoguide.Domain.Model.Request
{
    public class UsuarioReq
    {
        [Required(ErrorMessage = "El Nombre no puede ser Nulo")]
        [MaxLength(50, ErrorMessage = "El Nombre no puede ser mayor de 50 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Los Apellidos no puede ser Nulo")]
        [MaxLength(50, ErrorMessage = "Los Apellidos no puede ser mayor de 50 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El Correo no puede ser Nulo")]
        [EmailAddress]
        [MaxLength(50, ErrorMessage = "El Correo no puede ser mayor de 50 caracteres")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La Contraseña no puede ser Nulo")]
        public string Contrasenya { get; set; }

        public string ImagenUrl { get; set; }

        [Required(ErrorMessage = "El Tipo de Usuario no puede ser Nulo")]
        public string Tipo { get; set; }
    }
}
