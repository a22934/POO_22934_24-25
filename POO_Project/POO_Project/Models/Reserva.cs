using System;

namespace Models
{
    /// <summary>
    /// Representa uma reserva feita por um cliente para um apartamento.
    /// </summary>
    public class Reserva
    {
        /// <summary>
        /// Identificador único da reserva.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente que fez a reserva.
        /// </summary>
        public string NameClient { get; set; }

        /// <summary>
        /// O apartamento que foi reservado.
        /// </summary>
        public Apartment Apartament { get; set; }

        /// <summary>
        /// Data de início da reserva.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Data de fim da reserva.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Data em que o cliente fez o check-in (pode ser nula se ainda não fez check-in).
        /// </summary>
        public DateTime? DataCheckIn { get; set; }

        /// <summary>
        /// Data em que o cliente fez o check-out (pode ser nula se ainda não fez check-out).
        /// </summary>
        public DateTime? DataCheckOut { get; set; }

        /// <summary>
        /// Indica se o cliente já fez o check-in.
        /// </summary>
        public bool IsCheckedIn { get; set; }

        /// <summary>
        /// Construtor que inicializa os dados essenciais de uma reserva.
        /// </summary>
        /// <param name="id">ID da reserva.</param>
        /// <param name="nameClient">Nome do cliente.</param>
        /// <param name="apartamento">Apartamento reservado.</param>
        /// <param name="startDate">Data de início da reserva.</param>
        /// <param name="endDate">Data de fim da reserva.</param>
        public Reserva(int id, string nameClient, Apartment apartamento, DateTime startDate, DateTime endDate)
        {
            Id = id;
            NameClient = nameClient;
            Apartament = apartamento;
            StartDate = startDate;
            EndDate = endDate;
            DataCheckIn = null;  
            DataCheckOut = null; 
            IsCheckedIn = false; 
        }

        /// <summary>
        /// Método para representar a reserva como uma string legível.
        /// </summary>
        /// <returns>Uma string com o nome do cliente, o nome do apartamento e o período da reserva.</returns>
        public override string ToString()
        {
            return $"{NameClient} - {Apartament.Name} - {StartDate.ToShortDateString()} a {EndDate.ToShortDateString()}";
        }
    }
}
