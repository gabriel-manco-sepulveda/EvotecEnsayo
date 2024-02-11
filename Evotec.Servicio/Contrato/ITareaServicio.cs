using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evotec.DTO;

namespace Evotec.Servicio.Contrato
{
    public interface ITareaServicio
    {
        Task<List<TareaDTO>> Lista(string buscar);
        Task<List<TareaDTO>> Catalogo(string estado, string buscar);
        Task<TareaDTO> Obtener(int id);
        Task<TareaDTO> Crear(TareaDTO modelo);
        Task<bool> Editar(TareaDTO modelo);
        Task<bool> Eliminar(int id);
    }
}
