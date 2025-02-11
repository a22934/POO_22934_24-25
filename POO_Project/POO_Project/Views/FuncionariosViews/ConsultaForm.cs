using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public partial class ConsultaForm : Form
    {
        private ReservaController _reservaController; // Controller para Gerir reservas

        /// <summary>
        /// Inicializa uma nova instância do formulário <see cref="ConsultaForm"/>.
        /// </summary>
        /// <param name="reservaController">Controller de reservas.</param>
        public ConsultaForm(ReservaController reservaController)
        {
            InitializeComponent();
            _reservaController = reservaController; // Recebe o controller diretamente
            CarregarReservas(); // Carrega as reservas no DataGridView
        }

        /// <summary>
        /// Carrega as reservas do controller e exibe no DataGridView.
        /// </summary>
        private void CarregarReservas()
        {
            try
            {
                // Obtém a lista de reservas do controller
                List<Reserva> reservas = _reservaController.ListReservas();

                if (reservas.Count == 0)
                {
                    MessageBox.Show("Nenhuma reserva encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Exibe as reservas no DataGridView
                dataGridView1.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}