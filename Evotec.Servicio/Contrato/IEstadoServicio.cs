using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evotec.DTO;

namespace Evotec.Servicio.Contrato
{
    public interface IEstadoServicio
    {
        Task<List<EstadoDTO>> Lista(string buscar);
        Task<EstadoDTO> Obtener(int id);
        Task<EstadoDTO> Crear(EstadoDTO modelo);
        Task<bool> Editar(EstadoDTO modelo);
        Task<bool> Eliminar(int id);
    }
}
