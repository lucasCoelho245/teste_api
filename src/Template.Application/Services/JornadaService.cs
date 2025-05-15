using Template.Application.Dtos;
using Template.Domain.Entidades;
using Template.Domain.Repositorios;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Application.Services
{
    public class JornadaService
    {
        private readonly IJornadaRepository _jornadaRepository;

        public JornadaService(IJornadaRepository jornadaRepository)
        {
            _jornadaRepository = jornadaRepository;
        }

        public async Task<IEnumerable<JornadaDto>> ObterJornadas()
        {
            var jornadas = await _jornadaRepository.GetAllAsync();

            return jornadas.Select(j => new JornadaDto
            {
                TpJornada = j.TpJornada,
                IdRecorrencia = j.IdRecorrencia,
                IdE2E = j.IdE2E,
                IdConciliacaoRecebedor = j.IdConciliacaoRecebedor
            });
        }
    }
}