using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Models;

namespace Controllers
{
    /// <summary>
    /// Controlador responsável pela realização de check-in e check-out das reservas.
    /// </summary>
    public class CheckController
    {
        // Caminho do arquivo onde os dados das reservas são armazenados.
        private readonly string _filePath;

        /// <summary>
        /// Construtor do controlador de check-in e check-out.
        /// Inicializa o controlador com o caminho do arquivo de dados das reservas.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo onde as reservas serão carregadas e salvas.</param>
        public CheckController(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Realiza o check-in de uma reserva identificada pelo ID.
        /// </summary>
        /// <param name="reservaId">ID da reserva a ser realizada o check-in.</param>
        /// <returns>Uma tupla contendo o sucesso da operação e a mensagem de retorno.</returns>
        public (bool success, string message) DoCheckIn(int reservaId)
        {
            try
            {
                // Carrega a lista de reservas do arquivo.
                var reservas = DataLoader.LoadFromFile<Reserva>(_filePath);

                // Encontra a reserva com o ID fornecido.
                var reserva = reservas.FirstOrDefault(r => r.Id == reservaId);

                // Verifica se a reserva foi encontrada.
                if (reserva == null)
                    return (false, "Reserva não encontrada");

                // Verifica se o check-in já foi realizado.
                if (reserva.IsCheckedIn)
                    return (false, "Check-in já realizado anteriormente");

                // Realiza o check-in, definindo a data e alterando o estado da reserva.
                reserva.DataCheckIn = DateTime.Now;
                reserva.IsCheckedIn = true;

                // Salva a lista atualizada de reservas no arquivo.
                DataSaver.SaveToFile(reservas, _filePath);

                return (true, "Check-in realizado com sucesso");
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um status de falha com a mensagem de erro.
                return (false, $"Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Realiza o check-out de uma reserva identificada pelo ID.
        /// </summary>
        /// <param name="reservaId">ID da reserva a ser realizada o check-out.</param>
        /// <returns>Uma tupla contendo o sucesso da operação e a mensagem de retorno.</returns>
        public (bool success, string message) DoCheckOut(int reservaId)
        {
            try
            {
                // Carrega a lista de reservas do arquivo.
                var reservas = DataLoader.LoadFromFile<Reserva>(_filePath);

                // Encontra a reserva com o ID fornecido.
                var reserva = reservas.FirstOrDefault(r => r.Id == reservaId);

                // Verifica se a reserva foi encontrada.
                if (reserva == null)
                    return (false, "Reserva não encontrada");

                // Verifica se o check-in foi realizado antes de permitir o check-out.
                if (!reserva.IsCheckedIn)
                    return (false, "Check-out não permitido (check-in não realizado)");

                // Realiza o check-out, definindo a data e alterando o estado da reserva.
                reserva.DataCheckOut = DateTime.Now;
                reserva.IsCheckedIn = false;

                // Salva a lista atualizada de reservas no arquivo.
                DataSaver.SaveToFile(reservas, _filePath);

                return (true, "Check-out realizado com sucesso");
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um estado de falha com a mensagem de erro.
                return (false, $"Erro: {ex.Message}");
            }
        }
    }
}
