using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Domain.Entidades;
using Template.Domain.Repositorios;

namespace Template.Application.Services;

public class JornadaService
{
    private readonly IJornadaRepository _jornadaRepository;

    public JornadaService(IJornadaRepository jornadaRepository)
    {
        _jornadaRepository = jornadaRepository;
    }

    public async Task<IEnumerable<Jornada>> ObterJornadasAsync()
    {
        return await _jornadaRepository.GetAllAsync();
    }
}