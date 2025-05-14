using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Domain.Entidades;

namespace Template.Domain.Repositorios;

public class JornadaRepository : IJornadaRepository
{
    public Task<IEnumerable<Jornada>> GetAllAsync()
    {
        var jornadas = new List<Jornada>
        {
            new Jornada { Id = 1, Nome = "Jornada 1", DataInicio = DateTime.Now.AddDays(-1), DataFim = DateTime.Now },
            new Jornada { Id = 2, Nome = "Jornada 2", DataInicio = DateTime.Now.AddDays(-2), DataFim = DateTime.Now.AddDays(-1) }
        };

        return Task.FromResult<IEnumerable<Jornada>>(jornadas);
    }
}