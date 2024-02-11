using Evotec.DTO;

namespace Evotec.WebAssembly.Servicios.Contrato
{
    public interface IEstadoServicio
    {
        Task<ResponseDTO<List<EstadoDTO>>> Lista(string buscar);
        Task<ResponseDTO<EstadoDTO>> Obtener(int id);
        Task<ResponseDTO<EstadoDTO>> Crear(EstadoDTO modelo);
        Task<ResponseDTO<bool>> Editar(EstadoDTO modelo);
        Task<ResponseDTO<bool>> Eliminar(int id);

    }
}
