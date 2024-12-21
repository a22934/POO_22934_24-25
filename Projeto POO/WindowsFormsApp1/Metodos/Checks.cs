using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public static class Checks
    {
        /// <summary>
        /// Realiza o Check-in de uma reserva, marcando a data e alterando o estado da reserva.
        /// </summary>
        /// <param name="reserva">A reserva para a qual o check-in será realizado.</param>
        /// <param name="reservas">A lista de reservas atual, usada para persistência.</param>
        public static void RealizarCheckIn(Reserva reserva, List<Reserva> reservas)
        {
            if (reserva != null && !reserva.IsCheckedIn)
            {
                reserva.DataCheckIn = DateTime.Now;  // Marca a data de check-in
                reserva.IsCheckedIn = true;  // Marca como "checked-in"
                DataSaver.SalvarReservas(reservas);  // Salva as reservas após o check-in
            }
            else
            {
                MessageBox.Show("A reserva já está com check-in ou não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Realiza o Check-out de uma reserva, marcando a data e alterando o estado da reserva.
        /// </summary>
        /// <param name="reserva">A reserva para a qual o check-out será realizado.</param>
        /// <param name="reservas">A lista de reservas atual, usada para persistência.</param>
        public static void RealizarCheckOut(Reserva reserva, List<Reserva> reservas)
        {
            if (reserva != null && reserva.IsCheckedIn)
            {
                reserva.DataCheckOut = DateTime.Now;  // Marca a data de check-out
                reserva.IsCheckedIn = false;  // Marca como "não checked-in"
                DataSaver.SalvarReservas(reservas);  // Salva as reservas após o check-out
            }
            else
            {
                MessageBox.Show("A reserva não foi feita ou o cliente não fez check-in.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}

