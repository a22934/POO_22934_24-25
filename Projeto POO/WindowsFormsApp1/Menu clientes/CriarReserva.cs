using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CriarReservaForm : Form
    {
        private List<Apartment> apartments; // Adiciona a lista de apartamentos
        private List<Reserva> reservas; // Adiciona a lista de reservas
        private Client loggedClient;// Adiciona o cliente logado

        /// <summary>
        /// Inicializa uma nova instância do formulário <see cref="CriarReservaForm"/>.
        /// </summary>
        /// <param name="apartments">Lista de apartamentos disponíveis.</param>
        /// <param name="reservas">Lista de reservas existentes.</param>
        /// <param name="loggedClient">Cliente logado que está a criar a reserva.</param>
        public CriarReservaForm(List<Apartment> apartments, List<Reserva> reservas, Client loggedClient)
        {
            InitializeComponent();
            this.apartments = apartments;
            this.reservas = reservas;
            this.loggedClient = loggedClient;
            PopulateApartmentsComboBox();
        }
        /// <summary>
        /// Preenche o combobox com a lista de apartamentos disponíveis.
        /// </summary>
        private void PopulateApartmentsComboBox()
        {
            cbApartments.Items.Clear();
            foreach (var apartment in apartments)
            {
                cbApartments.Items.Add(apartment.Name);
            }
        }
        /// <summary>
        /// Lida com o evento de clique do botão "Reservar".
        /// Valida os dados e cria uma nova reserva para o cliente logado.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (cbApartments.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um apartamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedApartment = apartments[cbApartments.SelectedIndex];
            var dataInicio = dtpInicio.Value;
            var dataFim = dtpFim.Value;

            CriarReserva.CriarNovaReserva(loggedClient.Nome, selectedApartment, dataInicio, dataFim, reservas);
            this.Close();
        }
    }
}

