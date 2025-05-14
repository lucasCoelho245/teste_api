using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entidades;

namespace Template.Domain.Repositorios
{
    public class MockAutorizacaoRecorrenciaRepository : IAutorizacaoRecorrenciaRepository
    {
        // Lista simulada de dados
        private static readonly List<AutorizacaoRecorrencia> Autorizacoes = new List<AutorizacaoRecorrencia>
        {
            new AutorizacaoRecorrencia("123", "001"),
            new AutorizacaoRecorrencia("124", "002")
        };

        public AutorizacaoRecorrencia ObterPorId(string idAutorizacao, string idRecorrencia)
        {
            // Simula a consulta no banco de dados, mas usando a lista local
            return Autorizacoes.FirstOrDefault(a => a.IdAutorizacao == idAutorizacao && a.IdRecorrencia == idRecorrencia);
        }
    }
}
