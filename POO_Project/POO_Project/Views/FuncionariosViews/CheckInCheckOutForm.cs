using Controllers;
using Models;

namespace Views
{
    /// <summary>
    /// Formulário de Check-in e Check-out para gerir as reservas.
    /// </summary>
    public partial class CheckInCheckOutForm : Form
    {
        private ReservaController _reservaController;
        private List<Reserva> _reservas; // Lista de reservas

        /// <summary>
        /// Inicializa uma nova instância do formulário <see cref="CheckInCheckOutForm"/>.
        /// </summary>
        /// <param name="reservaController">Controller de reservas.</param>
        public CheckInCheckOutForm(ReservaController reservaController)
        {
            InitializeComponent();
            _reservaController = reservaController;
            _reservas = _reservaController.ListReservas(); // Carrega as reservas
            LoadReservas(); // Exibe as reservas no DataGridView
        }

        /// <summary>
        /// Carrega as reservas no DataGridView para exibir.
        /// Limpa e atualiza a tabela de reservas.
        /// </summary>
        private void LoadReservas()
        {
            dgvReservas.DataSource = null;
            // Define a lista de reservas como fonte de dados para exibição
            dgvReservas.DataSource = _reservas;
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Check-In".
        /// Realiza o check-in para a reserva selecionada.
        /// </summary>
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada na tabela
            if (dgvReservas.SelectedRows.Count > 0)
            {
                // Obtém o ID da reserva selecionada
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);

                // Realiza o check-in da reserva com o ID selecionado
                var result = _reservaController.CheckIn(reservaId);

                // Verifica o resultado da operação de check-in
                if (result.success)
                {
                    // Se o check-in for bem-sucedido, exibe a mensagem e atualiza a lista de reservas
                    MessageBox.Show(result.message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _reservas = _reservaController.ListReservas(); 
                    LoadReservas(); // Recarrega as reservas no DataGridView
                }
                else
                {
                    // Se ocorrer erro, exibe a mensagem de erro
                    MessageBox.Show(result.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Caso nenhuma reserva tenha sido selecionada, exibe um aviso
                MessageBox.Show("Selecione uma reserva para fazer check-in.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Check-Out".
        /// Realiza o check-out para a reserva selecionada.
        /// </summary>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada na tabela
            if (dgvReservas.SelectedRows.Count > 0)
            {
                // Obtém o ID da reserva selecionada
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);

                // Realiza o check-out da reserva com o ID selecionado
                var result = _reservaController.CheckOut(reservaId);

                // Verifica o resultado da operação de check-out
                if (result.success)
                {
                    MessageBox.Show(result.message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _reservas = _reservaController.ListReservas(); 
                    LoadReservas(); // Recarrega as reservas no DataGridView
                }
                else
                {
                    // Se ocorrer erro, exibe a mensagem de erro
                    MessageBox.Show(result.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Caso nenhuma reserva tenha sido selecionada, exibe um aviso
                MessageBox.Show("Selecione uma reserva para fazer check-out.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
