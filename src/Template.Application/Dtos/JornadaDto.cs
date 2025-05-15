using System;

namespace Template.Application.Dtos
{
    public class JornadaDto
    {
        public string TpJornada { get; set; }
        public string IdRecorrencia { get; set; }
        public string IdE2E { get; set; }
        public string IdConciliacaoRecebedor { get; set; }

        public string SituacaoJornada { get; set; }
        public DateTime? DtAgendamento { get; set; }
        public decimal? VlAgendamento { get; set; }
        public DateTime? DtPagamento { get; set; }
        public DateTime? DataHoraCriacao { get; set; }
        public DateTime? DataUltimaAtualizacao { get; set; }
    }
}