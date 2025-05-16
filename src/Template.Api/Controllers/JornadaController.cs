using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Template.Application.Services;

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

        [HttpGet("filtros")]
        public async Task<IActionResult> GetPorFiltros([FromQuery] string tpJornada = null,
            [FromQuery] string idRecorrencia = null,
            [FromQuery] string idE2E = null,
            [FromQuery] string idConciliacaoRecebedor = null)
        {
            var jornadas = await _jornadaService.ObterJornadasPorFiltros(tpJornada, idRecorrencia, idE2E, idConciliacaoRecebedor);
            return Ok(jornadas);
        }
    }
}