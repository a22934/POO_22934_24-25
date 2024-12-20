using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{
    public partial class CheckInCheckOutForm : Form
    {
        private List<Reserva> reservas;

        public CheckInCheckOutForm(List<Reserva> reservas)
        {
            InitializeComponent();
            this.reservas = reservas ?? new List<Reserva>();
            LoadReservas();
        }

        private void LoadReservas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservas;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);

                // Localiza a reserva com o Id selecionado
                Reserva reserva = reservas.FirstOrDefault(r => r.Id == reservaId);

                if (reserva != null)
                {
                    // Realiza o check-in
                    Checks.RealizarCheckIn(reserva,reservas);

                    // Exibe mensagem de sucesso
                    MessageBox.Show("Check-in efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recarrega as reservas na tabela
                    LoadReservas();
                }
                else
                {
                    MessageBox.Show("Reserva não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para fazer check-in.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);

                // Localiza a reserva com o Id selecionado
                Reserva reserva = reservas.FirstOrDefault(r => r.Id == reservaId);

                if (reserva != null)
                {
                    // Realiza o check-out
                    Checks.RealizarCheckOut(reserva, reservas);

                    // Remove a reserva da lista
                    reservas.Remove(reserva);

                    // Atualiza as reservas no arquivo JSON ou banco de dados
                    DataSaver.SalvarReservas(reservas);

                    // Exibe mensagem de sucesso
                    MessageBox.Show("Check-out efetuado com sucesso! A reserva foi removida.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recarrega as reservas na tabela
                    LoadReservas();
                }
                else
                {
                    MessageBox.Show("Reserva não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para fazer check-out.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
