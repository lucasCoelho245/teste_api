using Microsoft.AspNetCore.Mvc;
using Template.Application.Interfaces;
using Template.Application.Dto;

namespace Template.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorizacaoController : ControllerBase
    {
        private readonly IAutorizacaoService _autorizacaoService;

        public AutorizacaoController(IAutorizacaoService autorizacaoService)
        {
            _autorizacaoService = autorizacaoService;
        }

        [HttpPost("consultar")]
        public IActionResult ConsultarAutorizacao([FromBody] ConsultarAutorizacaoRequest request)
        {
            var resultado = _autorizacaoService.ObterDadosEntrada(request);

            if (resultado == null)
            {
                return NotFound("Dados não encontrados.");
            }

            return Ok(resultado);
        }
    }
}
