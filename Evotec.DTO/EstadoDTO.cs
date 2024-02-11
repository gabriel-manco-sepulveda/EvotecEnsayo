﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evotec.DTO
{
    public class EstadoDTO
    {
        public int IdEstado { get; set; }

        [Required(ErrorMessage ="Ingrese el nombre")]
        public string? Nombre { get; set; }
    }
}
