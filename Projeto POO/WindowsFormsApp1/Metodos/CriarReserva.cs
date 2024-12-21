using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class CriarReserva
    {/// <summary>
     /// Cria uma nova reserva, valida a disponibilidade do apartamento e guarda a reserva na lista de reservas.
     /// </summary>
     /// <param name="nomeCliente">Nome do cliente que está a realizar a reserva.</param>
     /// <param name="apartamento">O apartamento a ser reservado.</param>
     /// <param name="dataInicio">Data de início da reserva.</param>
     /// <param name="dataFim">Data de término da reserva.</param>
     /// <param name="reservas">A lista de reservas existentes, onde a nova reserva será adicionada.</param>
        public static void CriarNovaReserva(string nomeCliente, Apartment apartamento, DateTime dataInicio, DateTime dataFim, List<Reserva> reservas)
        {
            if (apartamento.IsDisponivel(dataInicio, dataFim, reservas))
            {
                // Obter o ID da nova reserva
                int novoId = reservas.Count > 0 ? reservas.Max(r => r.Id) + 1 : 1; // Gera um ID único (incremental)

                // Criar a nova reserva
                Reserva reserva = new Reserva(novoId, nomeCliente, apartamento, dataInicio, dataFim);

                // Adicionar a reserva à lista de reservas
                reservas.Add(reserva);

                // Guardar as reservas no ficheiro
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

