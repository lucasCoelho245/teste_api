using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Domain.Entidades;

namespace Template.Domain.Repositorios
{
    public class JornadaRepository : IJornadaRepository
    {
        private readonly List<Jornada> _jornadasMock = new()
        {
            new Jornada
            {
                Id = 1,
                TpJornada = "Jornada 1",
                IdRecorrencia = "Rec123",
                IdE2E = "E2E456",
                IdConciliacaoRecebedor = "Conc789",
                SituacaoJornada = "Ativa",
                DtAgendamento = DateTime.Now.AddDays(-2),
                VlAgendamento = 100.50m,
                DtPagamento = DateTime.Now.AddDays(-1),
                DataHoraCriacao = DateTime.Now.AddDays(-10),
                DataUltimaAtualizacao = DateTime.Now
            },
            new Jornada
            {
                Id = 2,
                TpJornada = "Jornada 2",
                IdRecorrencia = "Rec234",
                IdE2E = "E2E567",
                IdConciliacaoRecebedor = "Conc890",
                SituacaoJornada = "Pendente",
                DtAgendamento = DateTime.Now.AddDays(-3),
                VlAgendamento = 200.75m,
                DtPagamento = DateTime.Now.AddDays(-2),
                DataHoraCriacao = DateTime.Now.AddDays(-12),
                DataUltimaAtualizacao = DateTime.Now
            }
        };

        public Task<IEnumerable<Jornada>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Jornada>>(_jornadasMock);
        }

        public Task<Jornada> GetByTpJornadaAndIdRecorrenciaAsync(string tpJornada, string idRecorrencia)
        {
            var resultado = _jornadasMock.FirstOrDefault(j =>
                j.TpJornada == tpJornada && j.IdRecorrencia == idRecorrencia);

            return Task.FromResult(resultado);
        }
    }
}