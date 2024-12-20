using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class CriarReserva
    {
        public static void CriarNovaReserva(string nomeCliente, Apartment apartamento, DateTime dataInicio, DateTime dataFim, List<Reserva> reservas)
        {
            if (apartamento.IsDisponivel(dataInicio, dataFim, reservas))
            {
                Reserva reserva = new Reserva(nomeCliente, apartamento, dataInicio, dataFim);
                reservas.Add(reserva);
                DataSaver.SalvarReservas(reservas);
                MessageBox.Show("Reserva realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O apartamento não está disponível para o período selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

