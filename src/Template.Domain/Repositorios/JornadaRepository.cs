using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Domain.Entidades;

namespace Template.Domain.Repositorios
{
    public class JornadaRepository : IJornadaRepository
    {
        public Task<IEnumerable<Jornada>> GetAllAsync()
        {
            var jornadas = new List<Jornada>
            {
                new Jornada 
                { 
                    TpJornada = "Tipo 1",
                    IdRecorrencia = "Rec123",
                    IdE2E = "E2E456",
                    IdConciliacaoRecebedor = "Conc789"
                },
                new Jornada 
                { 
                    TpJornada = "Tipo 2",
                    IdRecorrencia = "Rec234",
                    IdE2E = "E2E567",
                    IdConciliacaoRecebedor = "Conc890"
                }
            };

            return Task.FromResult<IEnumerable<Jornada>>(jornadas);
        }
    }
}