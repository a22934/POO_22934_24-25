using System;

public class Reserva
{
    public string NomeCliente { get; set; }
    public Apartment Apartamento { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public Reserva(string nomeCliente, Apartment apartamento, DateTime dataInicio, DateTime dataFim)
    {
        NomeCliente = nomeCliente;
        Apartamento = apartamento;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }

    public override string ToString()
    {
        return $"{NomeCliente} - {Apartamento.Name} - {DataInicio.ToShortDateString()} a {DataFim.ToShortDateString()}";
    }
}

