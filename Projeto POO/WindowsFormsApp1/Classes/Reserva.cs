using System;

public class Reserva
{
    public int Id { get; set; } // Identificador único da reserva
    public string NomeCliente { get; set; }
    public Apartment Apartamento { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    // Propriedades adicionais para check-in e check-out
    public DateTime? DataCheckIn { get; set; } // Pode ser nulo até o check-in
    public DateTime? DataCheckOut { get; set; } // Pode ser nulo até o check-out
    public bool IsCheckedIn { get; set; } // Indica se o cliente fez check-in

    public Reserva(int id, string nomeCliente, Apartment apartamento, DateTime dataInicio, DateTime dataFim)
    {
        Id = id;
        NomeCliente = nomeCliente;
        Apartamento = apartamento;
        DataInicio = dataInicio;
        DataFim = dataFim;
        DataCheckIn = null; // Inicialmente, não há check-in
        DataCheckOut = null; // Inicialmente, não há check-out
        IsCheckedIn = false; // Inicialmente, o cliente não fez check-in
    }

    public override string ToString()
    {
        return $"{NomeCliente} - {Apartamento.Name} - {DataInicio.ToShortDateString()} a {DataFim.ToShortDateString()}";
    }
}
