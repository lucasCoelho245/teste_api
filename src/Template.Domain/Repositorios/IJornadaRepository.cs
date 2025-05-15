using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Domain.Entidades;

namespace Template.Domain.Repositorios
{
    public interface IJornadaRepository
    {
        Task<IEnumerable<Jornada>> GetAllAsync();

        Task<Jornada> GetByTpJornadaAndIdRecorrenciaAsync(string tpJornada, string idRecorrencia);
    }
}