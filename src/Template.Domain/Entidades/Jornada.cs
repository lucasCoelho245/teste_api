namespace Template.Domain.Entidades
{
    public class Jornada
    {
        public int Id { get; set; }
        public string TpJornada { get; set; }              
        public string IdRecorrencia { get; set; }        
        public string IdE2E { get; set; }                   
        public string IdConciliacaoRecebedor { get; set; }  
    }
}