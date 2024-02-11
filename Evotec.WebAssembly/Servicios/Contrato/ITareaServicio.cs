using Evotec.DTO;

namespace Evotec.WebAssembly.Servicios.Contrato
{
    public interface ITareaServicio
    {
        Task<ResponseDTO<List<TareaDTO>>> Lista(string buscar);
        Task<ResponseDTO<List<TareaDTO>>> Catalogo(string Estado, string buscar);
        Task<ResponseDTO<TareaDTO>> Obtener(int id);
        Task<ResponseDTO<EstadoDTO>> Crear(EstadoDTO modelo);
        Task<ResponseDTO<bool>> Editar(EstadoDTO modelo);
        Task<ResponseDTO<bool>> Eliminar(int id);
    }
}
