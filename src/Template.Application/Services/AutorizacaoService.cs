using Template.Application.Interfaces;
using Template.Application.Dto;
using Template.Domain.Repositorios;
using Template.Domain.Entidades;

namespace Template.Application.Services
{
    public class AutorizacaoService : IAutorizacaoService
    {
        private readonly IAutorizacaoRecorrenciaRepository _repository;

        public AutorizacaoService(IAutorizacaoRecorrenciaRepository repository)
        {
            _repository = repository;
        }

        public DadosEntradaResponse ObterDadosEntrada(ConsultarAutorizacaoRequest request)
        {
            var autorizacao = _repository.ObterPorId(request.IdAutorizacao, request.IdRecorrencia);

            return new DadosEntradaResponse
            {
                IdAutorizacao = autorizacao?.IdAutorizacao,
                IdRecorrencia = autorizacao?.IdRecorrencia
            };
        }
    }
}
