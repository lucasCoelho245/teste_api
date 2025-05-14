using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entidades;

namespace Template.Domain.Repositorios
{
    public class AutorizacaoRecorrenciaRepository : IAutorizacaoRecorrenciaRepository
    {
        private readonly ApplicationDbContext _context;

        public AutorizacaoRecorrenciaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public AutorizacaoRecorrencia ObterPorId(string idAutorizacao, string idRecorrencia)
        {
            return _context.AutorizacaoRecorrencia
                           .FirstOrDefault(a => a.IdAutorizacao == idAutorizacao && a.IdRecorrencia == idRecorrencia);
        }
    }
}
