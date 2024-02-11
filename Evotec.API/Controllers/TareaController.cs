using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Evotec.Servicio.Contrato;
using Evotec.DTO;
using Evotec.Servicio.Implementacion;

namespace Evotec.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly ITareaServicio _tareaServicio;
        public TareaController(ITareaServicio tareaServicio)
        {
            _tareaServicio = tareaServicio;
        }

        [HttpGet("Lista/{buscar:alpha?}")]
        public async Task<IActionResult> Lista(string buscar = "NA")
        {
            var response = new ResponseDTO<List<TareaDTO>>();

            try
            {
                if (buscar == "NA") buscar = "";
                response.EsCorrecto = true;
                response.Resultado = await _tareaServicio.Lista(buscar);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpGet("Catalogo/{estado:alpha}/{buscar:alpha?}")]
        public async Task<IActionResult> Catalogo(string estado, string buscar = "NA")
        {
            var response = new ResponseDTO<List<TareaDTO>>();

            try
            {
                if (estado.ToLower() == "todos")buscar = "";
                if (buscar == "NA") buscar = "";

                response.EsCorrecto = true;
                response.Resultado = await _tareaServicio.Catalogo(estado, buscar);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpGet("Obtener/{Id:int}")]
        public async Task<IActionResult> Obtener(int Id)
        {
            var response = new ResponseDTO<TareaDTO>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _tareaServicio.Obtener(Id);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody] TareaDTO modelo)
        {
            var response = new ResponseDTO<TareaDTO>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _tareaServicio.Crear(modelo);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpPut("Editar")]
        public async Task<IActionResult> Editar([FromBody] TareaDTO modelo)
        {
            var response = new ResponseDTO<bool>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _tareaServicio.Editar(modelo);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpPut("Eliminar/{Id:int}")]
        public async Task<IActionResult> Eliminar(int Id)
        {
            var response = new ResponseDTO<bool>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _tareaServicio.Eliminar(Id);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }
    }
}
