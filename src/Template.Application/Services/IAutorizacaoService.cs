using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Application.Dto;

namespace Template.Application.Interfaces
{
    public interface IAutorizacaoService
    {
        DadosEntradaResponse ObterDadosEntrada(ConsultarAutorizacaoRequest request);
    }
}

