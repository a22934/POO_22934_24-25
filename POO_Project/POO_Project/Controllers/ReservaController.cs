using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Data;

namespace Controllers
{
    /// <summary>
    /// Controlador responsável pela gestão das reservas, incluindo criação, check-in e check-out.
    /// </summary>
    public class ReservaController
    {
        private readonly string _filePath;
        private List<Reserva> _reservas;

        /// <summary>
        /// Construtor do controlador de reservas.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo onde as reservas são armazenadas.</param>
        public ReservaController(string filePath)
        {
            _filePath = filePath;
            _reservas = DataLoader.LoadFromFile<Reserva>(_filePath);
        }

        /// <summary>
        /// Lista todas as reservas.
        /// </summary>
        /// <returns>Uma lista contendo todas as reservas armazenadas.</returns>
        public List<Reserva> ListReservas()
        {
            return DataLoader.LoadFromFile<Reserva>(_filePath);
        }

        /// <summary>
        /// Cria uma nova reserva, verificando se o apartamento está disponível no período selecionado.
        /// </summary>
        /// <param name="NameClient">Nome do cliente que está a executar a reserva.</param>
        /// <param name="apartamento">Apartamento a ser reservado.</param>
        /// <param name="StartDate">Data de início da reserva.</param>
        /// <param name="EndDate">Data de fim da reserva.</param>
        /// <returns>Tupla indicando se a operação foi bem-sucedida e uma mensagem.</returns>
        public (bool success, string message) CriarReserva(string NameClient, Apartment apartamento, DateTime StartDate, DateTime EndDate)
        {
            try
            {
                // Verifica se o apartamento está disponível no período selecionado
                if (!apartamento.IsAvailable(StartDate, EndDate, _reservas))
                {
                    return (false, "O apartamento não está disponível no período selecionado.");
                }

                // Garante um ID único utilizando o maior ID já existente e incrementando 1
                int novoId = _reservas.Any() ? _reservas.Max(r => r.Id) + 1 : 1;

                // Cria a nova reserva
                var novaReserva = new Reserva(
                    id: novoId,
                    nameClient: NameClient,
                    apartamento: apartamento,
                    startDate: StartDate,
                    endDate: EndDate
                );

                // Adiciona a reserva à lista
                _reservas.Add(novaReserva);

                // Salva as reservas no arquivo
                DataSaver.SaveToFile(_reservas, _filePath);

                return (true, $"Reserva criada com sucesso! ID: {novoId}");
            }
            catch (Exception ex)
            {
                return (false, $"Erro ao criar reserva: {ex.Message}");
            }
        }

        /// <summary>
        /// Realiza o check-in de uma reserva, marcando a reserva como "checked-in".
        /// </summary>
        /// <param name="reservaId">ID da reserva a ser executado o check-in.</param>
        /// <returns>Tupla indicando se a operação foi bem-sucedida e uma mensagem.</returns>
        public (bool success, string message) CheckIn(int reservaId)
        {
            try
            {
                var reservas = DataLoader.LoadFromFile<Reserva>(_filePath);
                var reserva = reservas.FirstOrDefault(r => r.Id == reservaId);

                if (reserva != null)
                {
                    // Define a data de check-in e marca como "checked-in"
                    reserva.DataCheckIn = DateTime.Now;
                    reserva.IsCheckedIn = true;
                    DataSaver.SaveToFile(reservas, _filePath);

                    return (true, "Check-in realizado com sucesso!");
                }
                else
                {
                    return (false, "Reserva não encontrada.");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Erro ao realizar check-in: {ex.Message}");
            }
        }

        /// <summary>
        /// Realiza o check-out de uma reserva, removendo a reserva após o check-out.
        /// </summary>
        /// <param name="reservaId">ID da reserva a ser executado o check-out.</param>
        /// <returns>Tupla indicando se a operação foi bem-sucedida e uma mensagem.</returns>
        public (bool success, string message) CheckOut(int reservaId)
        {
            try
            {
                var reservas = DataLoader.LoadFromFile<Reserva>(_filePath);
                var reserva = reservas.FirstOrDefault(r => r.Id == reservaId);

                if (reserva != null)
                {
                    // Define a data de check-out e remove a reserva
                    reserva.DataCheckOut = DateTime.Now;
                    reservas.Remove(reserva); // Remove a reserva após o check-out
                    DataSaver.SaveToFile(reservas, _filePath);

                    return (true, "Check-out realizado com sucesso!");
                }
                else
                {
                    return (false, "Reserva não encontrada.");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Erro ao realizar check-out: {ex.Message}");
            }
        }
    }
}
