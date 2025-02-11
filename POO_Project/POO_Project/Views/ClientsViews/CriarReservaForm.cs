using Controllers;
using Models;

namespace Views
{
    /// <summary>
    /// Formulário para criação de reserva.
    /// Permite ao cliente logado escolher um apartamento e definir as datas de reserva.
    /// </summary>
    public partial class CriarReservaForm : Form
    {
        // Controladores para gerir apartamentos e reservas
        private readonly ReservaController _reservaController;
        private readonly ApartmentController _apartmentController;

        // Cliente logado que realizará a reserva
        private readonly Client _loggedClient;

        /// <summary>
        /// Construtor da classe CriarReservaForm.
        /// Inicializa os controladores e o cliente logado.
        /// Também preenche o ComboBox com os apartamentos disponíveis.
        /// </summary>
        /// <param name="apartmentController">Controlador de apartamentos.</param>
        /// <param name="reservaController">Controlador de reservas.</param>
        /// <param name="loggedClient">Cliente logado.</param>
        public CriarReservaForm(ApartmentController apartmentController, ReservaController reservaController, Client loggedClient)
        {
            InitializeComponent();
            _apartmentController = apartmentController;
            _reservaController = reservaController;
            _loggedClient = loggedClient;
            PopulateApartmentsComboBox();
        }

        /// <summary>
        /// Preenche o ComboBox com a lista de apartamentos disponíveis.
        /// Obtém os apartamentos através do controlador de apartamentos.
        /// </summary>
        private void PopulateApartmentsComboBox()
        {
            cbApartments.Items.Clear();
            var apartments = _apartmentController.ListApartments();
            foreach (var apartment in apartments)
            {
                cbApartments.Items.Add(apartment.Name);
            }
        }

        /// <summary>
        /// Evento de clique no botão "Reservar".
        /// Realiza a reserva do apartamento selecionado com as datas escolhidas.
        /// </summary>
        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o user selecionou um apartamento
                if (cbApartments.SelectedIndex == -1)
                {
                    // Exibe uma mensagem de erro caso nenhum apartamento tenha sido selecionado
                    MessageBox.Show("Selecione um apartamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtém o apartamento selecionado pelo cliente
                var selectedApartment = _apartmentController.ListApartments()[cbApartments.SelectedIndex];

                // Obtém as datas selecionadas para a reserva
                var StartDate = dtpStart.Value;
                var EndDate = dtpEnd.Value;

                // Valida as datas
                if (StartDate >= EndDate)
                {
                    // Exibe uma mensagem de erro se a data de início for igual ou posterior à data de fim
                    MessageBox.Show("A data de início deve ser anterior à data de fim.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chama o controlador de reservas para criar a reserva
                var result = _reservaController.CriarReserva(
                    _loggedClient.Name,        
                    selectedApartment,         
                    StartDate,                 
                    EndDate                    
                );

                // Verifica se a criação da reserva foi bem-sucedida
                if (result.success)
                {
                    // Exibe mensagem de sucesso e fecha o formulário
                    MessageBox.Show(result.message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Fecha o formulário após o sucesso
                }
                else
                {
                    // Exibe mensagem de erro caso a criação da reserva falhe
                    MessageBox.Show(result.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro em caso de exceção
                MessageBox.Show($"Erro ao criar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
