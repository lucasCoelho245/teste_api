using System;

namespace Template.Domain.Entidades;

public class Jornada
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
}