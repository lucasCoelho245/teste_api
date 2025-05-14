using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Template.Application.Services;

namespace Template.Api.Controllers;

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
        var jornadas = await _jornadaService.ObterJornadasAsync();
        return Ok(jornadas);
    }
}