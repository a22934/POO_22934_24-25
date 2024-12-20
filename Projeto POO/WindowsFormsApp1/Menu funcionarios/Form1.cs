using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Client> clients { get; set; } = new List<Client>(); // Adiciona a lista de clientes
        public List<Apartment> Apartments { get; set; } = new List<Apartment>(); // Adiciona a lista de apartamentos
        private List<Reserva> reservas = new List<Reserva>(); // Adiciona a lista de reservas

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Form1"/>.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            reservas = DataLoader.CarregarReservas(); // Carregar reservas do arquivo
        }

        /// <summary>
        /// Evento para o botão "Clientes".
        /// </summary>
        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(this.clients);
            clientForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Registros".
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrosForm registrosForm = new RegistrosForm
            {
                Clients = this.clients
            };

            registrosForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Apartamentos".
        /// </summary>
        private void btnApartments_Click(object sender, EventArgs e)
        {
            ApartmentForm apartmentForm = new ApartmentForm(this.Apartments, true);
            apartmentForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Consultas".
        /// </summary>
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ConsultaForm consultaForm = new ConsultaForm();
            consultaForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Check-in and Check-out".
        /// </summary>
        private void btnCheckInCheckOut_Click(object sender, EventArgs e)
        {
            CheckInCheckOutForm checkInCheckOutForm = new CheckInCheckOutForm(reservas);
            checkInCheckOutForm.ShowDialog();
        }
    }
}
