using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Domain.Entidades;

namespace Template.Domain.Repositorios;

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
        return Task.FromResult(_jornadasMock.AsEnumerable());
    }

    public Task<Jornada> GetByTpJornadaAndIdRecorrenciaAsync(string tpJornada, string idRecorrencia)
    {
        var resultado = _jornadasMock.FirstOrDefault(j => 
            j.TpJornada.Equals(tpJornada, StringComparison.OrdinalIgnoreCase) && 
            j.IdRecorrencia.Equals(idRecorrencia, StringComparison.OrdinalIgnoreCase));

        return Task.FromResult(resultado);
    }

    public Task<IEnumerable<Jornada>> GetByFiltersAsync(string tpJornada = null, string idRecorrencia = null, string idE2E = null, string idConciliacaoRecebedor = null)
    {
        var query = _jornadasMock.AsQueryable();

        query = FilterByTpJornada(query, tpJornada);
        query = FilterByIdRecorrencia(query, idRecorrencia);
        query = FilterByIdE2E(query, idE2E);
        query = FilterByIdConciliacaoRecebedor(query, idConciliacaoRecebedor);

        return Task.FromResult(query.AsEnumerable());
    }

    private IQueryable<Jornada> FilterByTpJornada(IQueryable<Jornada> query, string tpJornada)
    {
        if (string.IsNullOrWhiteSpace(tpJornada))
            return query;
        return query.Where(j => j.TpJornada.Equals(tpJornada, StringComparison.OrdinalIgnoreCase));
    }

    private IQueryable<Jornada> FilterByIdRecorrencia(IQueryable<Jornada> query, string idRecorrencia)
    {
        if (string.IsNullOrWhiteSpace(idRecorrencia))
            return query;
        return query.Where(j => j.IdRecorrencia.Equals(idRecorrencia, StringComparison.OrdinalIgnoreCase));
    }

    private IQueryable<Jornada> FilterByIdE2E(IQueryable<Jornada> query, string idE2E)
    {
        if (string.IsNullOrWhiteSpace(idE2E))
            return query;
        return query.Where(j => j.IdE2E.Equals(idE2E, StringComparison.OrdinalIgnoreCase));
    }

    private IQueryable<Jornada> FilterByIdConciliacaoRecebedor(IQueryable<Jornada> query, string idConciliacaoRecebedor)
    {
        if (string.IsNullOrWhiteSpace(idConciliacaoRecebedor))
            return query;
        return query.Where(j => j.IdConciliacaoRecebedor.Equals(idConciliacaoRecebedor, StringComparison.OrdinalIgnoreCase));
    }
}