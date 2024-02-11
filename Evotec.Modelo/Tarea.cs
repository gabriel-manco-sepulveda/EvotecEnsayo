using System;
using System.Collections.Generic;

namespace Evotec.Modelo;

public partial class Tarea
{
    public int IdTarea { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? IdEstado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }
}
