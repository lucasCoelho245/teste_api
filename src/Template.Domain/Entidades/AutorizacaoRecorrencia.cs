using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Entidades
{
    public class AutorizacaoRecorrencia
    {
        public string IdAutorizacao { get; private set; }
        public string IdRecorrencia { get; private set; }

        public AutorizacaoRecorrencia(string idAutorizacao, string idRecorrencia)
        {
            IdAutorizacao = idAutorizacao;
            IdRecorrencia = idRecorrencia;
        }
    }
}
