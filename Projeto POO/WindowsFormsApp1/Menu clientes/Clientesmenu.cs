using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{
    public partial class ClientesMenu : Form
    {
        public List<Apartment> Apartments { get; set; } // Adiciona a lista de apartamentos
        private List<Reserva> reservas; // Adiciona a lista de reservas
        private Client loggedClient; // Adiciona o cliente logado
        /// <summary>
        /// Inicializa uma nova instância do formulário <see cref="ClientesMenu"/>.
        /// </summary>
        /// <param name="apartments">Lista de apartamentos disponíveis.</param>
        /// <param name="loggedClient">Cliente atualmente logado.</param>
        public ClientesMenu(List<Apartment> apartments, Client loggedClient)
        {
            InitializeComponent();
            this.Apartments = apartments ?? new List<Apartment>();
            this.reservas = DataLoader.CarregarReservas();
            this.loggedClient = loggedClient;
        }
        /// <summary>
        /// Lida com o evento de clique do botão "Listar Apartamentos".
        /// Abre o formulário de listagem de apartamentos.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnListApartments_Click(object sender, EventArgs e)
        {
            ApartmentForm apartmentForm = new ApartmentForm(this.Apartments, false);
            apartmentForm.ShowDialog();
        }
        /// <summary>
        /// Lida com o evento de clique do botão "Criar Reserva".
        /// Abre o formulário para criação de uma nova reserva.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnCriarReserva_Click(object sender, EventArgs e)
        {
            CriarReservaForm criarReservaForm = new CriarReservaForm(this.Apartments, this.reservas, this.loggedClient);
            criarReservaForm.ShowDialog();
        }
    }
}
