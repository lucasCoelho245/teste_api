using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Entidades
{
    public interface IAutorizacaoRecorrenciaRepository
    {
        AutorizacaoRecorrencia ObterPorId(string idAutorizacao, string idRecorrencia);
    }
}
