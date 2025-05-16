using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Domain.Entidades;

namespace Template.Domain.Repositorios
{
    public interface IJornadaRepository
    {
        Task<IEnumerable<Jornada>> GetAllAsync();

        Task<Jornada> GetByTpJornadaAndIdRecorrenciaAsync(string tpJornada, string idRecorrencia);

        Task<IEnumerable<Jornada>> GetByFiltersAsync(
            string tpJornada = null, 
            string idRecorrencia = null, 
            string idE2E = null, 
            string idConciliacaoRecebedor = null);
    }
}