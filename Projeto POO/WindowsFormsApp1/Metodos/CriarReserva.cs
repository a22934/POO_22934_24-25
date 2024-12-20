using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class CriarReserva
    {
        public static void CriarNovaReserva(string nomeCliente, Apartment apartamento, DateTime dataInicio, DateTime dataFim, List<Reserva> reservas)
        {
            if (apartamento.IsDisponivel(dataInicio, dataFim, reservas))
            {
                // Gerar um novo ID, por exemplo, baseado no tamanho da lista de reservas (ou outro método de geração)
                int novoId = reservas.Count > 0 ? reservas.Max(r => r.Id) + 1 : 1; // Gera um ID único (incremental)

                // Criar a nova reserva com o ID gerado
                Reserva reserva = new Reserva(novoId, nomeCliente, apartamento, dataInicio, dataFim);

                // Adicionar a nova reserva à lista
                reservas.Add(reserva);

                // Salvar as reservas
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

