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
                IdConciliacaoRecebedor = j.IdConciliacaoRecebedor,
                SituacaoJornada = j.SituacaoJornada,
                DtAgendamento = j.DtAgendamento,
                VlAgendamento = j.VlAgendamento,
                DtPagamento = j.DtPagamento,
                DataHoraCriacao = j.DataHoraCriacao,
                DataUltimaAtualizacao = j.DataUltimaAtualizacao
            });
        }

        public async Task<JornadaDto> ObterJornadaPorFiltro(string tpJornada, string idRecorrencia)
        {
            var jornada = await _jornadaRepository.GetByTpJornadaAndIdRecorrenciaAsync(tpJornada, idRecorrencia);

            if (jornada == null)
                return null;

            return new JornadaDto
            {
                TpJornada = jornada.TpJornada,
                IdRecorrencia = jornada.IdRecorrencia,
                IdE2E = jornada.IdE2E,
                IdConciliacaoRecebedor = jornada.IdConciliacaoRecebedor,
                SituacaoJornada = jornada.SituacaoJornada,
                DtAgendamento = jornada.DtAgendamento,
                VlAgendamento = jornada.VlAgendamento,
                DtPagamento = jornada.DtPagamento,
                DataHoraCriacao = jornada.DataHoraCriacao,
                DataUltimaAtualizacao = jornada.DataUltimaAtualizacao
            };
        }
    }
}
