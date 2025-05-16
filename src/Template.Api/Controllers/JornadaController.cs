using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Domain.Entidades;
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

        // Cenário 01: Retorna todos os dados de entrada
        [HttpGet]
        public async Task<IEnumerable<Jornada>> Get()
        {
            return await _jornadaService.ObterJornadas();
        }

        // Cenário 02.1: Consulta por tpJornada e idRecorrencia (única ocorrência)
        [HttpGet("filtro")]
        public async Task<IActionResult> GetPorTpJornadaERecorrencia([FromQuery] string tpJornada, [FromQuery] string idRecorrencia)
        {
            var jornada = await _jornadaService.ObterJornadaPorTpJornadaERecorrencia(tpJornada, idRecorrencia);
            if (jornada == null)
                return NotFound();
            return Ok(jornada);
        }

        // Cenário 02.2: Consulta por tpJornada e idE2E (única ocorrência)
        [HttpGet("filtro-agendamento")]
        public async Task<IActionResult> GetPorTpJornadaEIdE2E([FromQuery] string tpJornada, [FromQuery] string idE2E)
        {
            var jornada = await _jornadaService.ObterJornadaPorTpJornadaEIdE2E(tpJornada, idE2E);
            if (jornada == null)
                return NotFound();
            return Ok(jornada);
        }

        // Cenário 02.3: Consulta por outras combinações (um ou mais registros)
        [HttpGet("filtros")]
        public async Task<IEnumerable<Jornada>> GetPorFiltros(
            [FromQuery] string tpJornada = null,
            [FromQuery] string idRecorrencia = null,
            [FromQuery] string idE2E = null,
            [FromQuery] string idConciliacaoRecebedor = null)
        {
            return await _jornadaService.ObterJornadasPorFiltros(tpJornada, idRecorrencia, idE2E, idConciliacaoRecebedor);
        }
    }
}
