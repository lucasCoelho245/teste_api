using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Template.Application.Services;
using Template.Domain.Entidades;

namespace Template.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JornadaController : ControllerBase
    {
        private readonly JornadaService _jornadaService;

        public JornadaController(JornadaService jornadaService)
        {
            _jornadaService = jornadaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var jornadas = await _jornadaService.ObterJornadas();
            return Ok(jornadas);
        }

        [HttpGet("filtro")]
        public async Task<IActionResult> GetPorFiltro([FromQuery] string tpJornada, [FromQuery] string idRecorrencia)
        {
            var jornada = await _jornadaService.ObterJornadaPorFiltro(tpJornada, idRecorrencia);
            if (jornada == null)
                return NotFound();

            return Ok(jornada);
        }
    }
}