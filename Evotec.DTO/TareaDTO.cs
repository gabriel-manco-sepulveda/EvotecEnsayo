using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evotec.DTO
{
    public class TareaDTO
    {
        public int IdTarea { get; set; }

        [Required(ErrorMessage ="Ingrese el nombre")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el la descripción")]
        public string? Descripcion { get; set; }

        public int? IdEstado { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual EstadoDTO? IdEstadoNavigation { get; set; }
    }
}
