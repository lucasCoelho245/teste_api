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

        public Task<Jornada> ObterJornadaPorTpJornadaERecorrencia(string tpJornada, string idRecorrencia)
        {
            return _jornadaRepository.GetByTpJornadaAndIdRecorrenciaAsync(tpJornada, idRecorrencia);
        }

        public Task<Jornada> ObterJornadaPorTpJornadaEIdE2E(string tpJornada, string idE2E)
        {
            return _jornadaRepository.GetByTpJornadaAndIdE2EAsync(tpJornada, idE2E);
        }

        public Task<IEnumerable<Jornada>> ObterJornadasPorFiltros(string tpJornada = null, string idRecorrencia = null, string idE2E = null, string idConciliacaoRecebedor = null)
        {
            return _jornadaRepository.GetByFiltersAsync(tpJornada, idRecorrencia, idE2E, idConciliacaoRecebedor);
        }
    }
}