using System;

public class Reserva
{
    public int Id { get; set; } // Identificador único da reserva
    public string NomeCliente { get; set; } // Nome do cliente
    public Apartment Apartamento { get; set; } // Apartamento reservado
    public DateTime DataInicio { get; set; } // Data de início da reserva
    public DateTime DataFim { get; set; } // Data de fim da reserva

    // Propriedades adicionais para check-in e check-out
    public DateTime? DataCheckIn { get; set; } // Pode ser nulo até o check-in
    public DateTime? DataCheckOut { get; set; } // Pode ser nulo até o check-out
    public bool IsCheckedIn { get; set; } // Indica se o cliente já fez check-in
    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="Reserva"/>.
    /// </summary>
    /// <param name="id">Identificador único da reserva.</param>
    /// <param name="nomeCliente">Nome do cliente que realizou a reserva.</param>
    /// <param name="apartamento">Apartamento associado à reserva.</param>
    /// <param name="dataInicio">Data de início da reserva.</param>
    /// <param name="dataFim">Data de fim da reserva.</param>
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
    /// <summary>
    /// Retorna uma representação textual da reserva.
    /// </summary>
    /// <returns>Uma string que descreve a reserva.</returns>
    public override string ToString()
    {
        return $"{NomeCliente} - {Apartamento.Name} - {DataInicio.ToShortDateString()} a {DataFim.ToShortDateString()}";
    }
}
