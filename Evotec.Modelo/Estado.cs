using System;
using System.Collections.Generic;

namespace Evotec.Modelo;

public partial class Estado
{
    public int IdEstado { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
}
