using Evotec.DTO;
using Evotec.WebAssembly.Servicios.Contrato;
using System.Net.Http.Json;

namespace Evotec.WebAssembly.Servicios.Implementacion
{
    public class TareaServicio: ITareaServicio
    {
        private readonly HttpClient _httpClient;

        public TareaServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<List<TareaDTO>>> Catalogo(string estado, string buscar)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<List<TareaDTO>>>($"Tarea/Catalogo/{estado}/{buscar}");
        }

        public async Task<ResponseDTO<EstadoDTO>> Crear(EstadoDTO modelo)
        {
            var response = await _httpClient.PostAsJsonAsync("Tarea/Crear", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<EstadoDTO>>();
            return result!;
        }

        public async Task<ResponseDTO<bool>> Editar(EstadoDTO modelo)
        {
            var response = await _httpClient.PutAsJsonAsync("Tarea/Editar", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<bool>>();
            return result!;
        }

        public async Task<ResponseDTO<bool>> Eliminar(int id)
        {
            return await _httpClient.DeleteFromJsonAsync<ResponseDTO<bool>>($"Tarea/Eliminar/{id}");
        }

        public async Task<ResponseDTO<List<TareaDTO>>> Lista(string buscar)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<List<TareaDTO>>>($"Tarea/Lista/{buscar}");
        }

        public async Task<ResponseDTO<TareaDTO>> Obtener(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<TareaDTO>>($"Tarea/Obtener/{id}");
        }
    }
}
