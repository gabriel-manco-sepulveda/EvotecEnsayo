using Evotec.DTO;
using Evotec.WebAssembly.Servicios.Contrato;
using System.Net.Http.Json;

namespace Evotec.WebAssembly.Servicios.Implementacion
{
    public class EstadoServicio:IEstadoServicio
    {
        private readonly HttpClient _httpClient;

        public EstadoServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<EstadoDTO>> Crear(EstadoDTO modelo)
        {
            var response = await _httpClient.PostAsJsonAsync("Estado/Crear", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<EstadoDTO>>();
            return result!;
        }

        public async Task<ResponseDTO<bool>> Editar(EstadoDTO modelo)
        {
            var response = await _httpClient.PutAsJsonAsync("Estado/Editar", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<bool>>();
            return result!;
        }

        public async Task<ResponseDTO<bool>> Eliminar(int id)
        {
            return await _httpClient.DeleteFromJsonAsync<ResponseDTO<bool>>($"Estado/Eliminar/{id}");
        }

        public async Task<ResponseDTO<List<EstadoDTO>>> Lista(string buscar)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<List<EstadoDTO>>>($"Estado/Lista/{buscar}");
        }

        public async Task<ResponseDTO<EstadoDTO>> Obtener(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<EstadoDTO>>($"Estado/Obtener/{id}");
        }
    }
}
