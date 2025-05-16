using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Template.Domain.Entidades;
using Template.Domain.Repositorios;

namespace Template.Infra.Repositorios
{
    public class JornadaRepository : IJornadaRepository
    {
        private readonly IDbConnection _connection;

        public JornadaRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Jornada>> GetAllAsync()
        {
            var sql = "SELECT * FROM Jornadas";
            return await _connection.QueryAsync<Jornada>(sql);
        }

        public async Task<Jornada> GetByTpJornadaAndIdRecorrenciaAsync(string tpJornada, string idRecorrencia)
        {
            var sql = @"
                SELECT * FROM Jornadas 
                WHERE TpJornada = @TpJornada 
                  AND IdRecorrencia = @IdRecorrencia
                  AND TpJornada IN ('Jornada 1', 'Jornada 2', 'Jornada 3', 'Jornada 4')
            ";
            return await _connection.QueryFirstOrDefaultAsync<Jornada>(sql, new { TpJornada = tpJornada, IdRecorrencia = idRecorrencia });
        }

        public async Task<Jornada> GetByTpJornadaAndIdE2EAsync(string tpJornada, string idE2E)
        {
            var sql = @"
                SELECT * FROM Jornadas
                WHERE TpJornada IN ('AGND', 'NTAG', 'RIFL')
                  AND TpJornada = @TpJornada
                  AND IdE2E = @IdE2E
            ";
            return await _connection.QueryFirstOrDefaultAsync<Jornada>(sql, new { TpJornada = tpJornada, IdE2E = idE2E });
        }

        public async Task<IEnumerable<Jornada>> GetByFiltersAsync(string tpJornada = null, string idRecorrencia = null, string idE2E = null, string idConciliacaoRecebedor = null)
        {
            var sql = @"
                SELECT * FROM Jornadas
                WHERE (@TpJornada IS NULL OR TpJornada = @TpJornada)
                  AND (@IdRecorrencia IS NULL OR IdRecorrencia = @IdRecorrencia)
                  AND (@IdE2E IS NULL OR IdE2E = @IdE2E)
                  AND (@IdConciliacaoRecebedor IS NULL OR IdConciliacaoRecebedor = @IdConciliacaoRecebedor)
            ";
            return await _connection.QueryAsync<Jornada>(sql, new
            {
                TpJornada = tpJornada,
                IdRecorrencia = idRecorrencia,
                IdE2E = idE2E,
                IdConciliacaoRecebedor = idConciliacaoRecebedor
            });
        }
    }
}
