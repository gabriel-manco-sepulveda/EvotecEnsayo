using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evotec.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage ="Ingrese nombre completo")]
        public string? NombreCompleto { get; set; }

        [Required(ErrorMessage = "Ingrese el correo")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "Ingrese su clave")]
        public string? Clave { get; set; }

        [Required(ErrorMessage = "Confirme su clave")]
        public string? ConfirmarClave { get; set; }

        public string? Rol { get; set; }

    }
}
