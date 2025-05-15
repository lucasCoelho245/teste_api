using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Domain.Entidades;
using Template.Domain.Repositorios;

namespace Template.Application.Services
{
    public class JornadaService
    {
        private readonly IJornadaRepository _jornadaRepository;

        public JornadaService(IJornadaRepository jornadaRepository)
        {
            _jornadaRepository = jornadaRepository;
        }

        public Task<IEnumerable<Jornada>> ObterJornadas()
        {
            return _jornadaRepository.GetAllAsync();
        }

        public Task<Jornada> ObterJornadaPorFiltro(string tpJornada, string idRecorrencia)
        {
            return _jornadaRepository.GetByTpJornadaAndIdRecorrenciaAsync(tpJornada, idRecorrencia);
        }
    }
}