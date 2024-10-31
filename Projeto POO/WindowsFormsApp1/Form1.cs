using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Client> clients = new List<Client>();
        public List<Apartment> Apartments { get; set; } = new List<Apartment>();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para o botão "Clientes"
        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm
            {
                Clients = this.clients // Passa a lista de clientes do Form1
            };
            clientForm.ShowDialog();
        }

        // Evento para o botão "Registros"
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do RegistrosForm
            RegistrosForm registrosForm = new RegistrosForm
            {
                Clients = this.clients // Passa a lista de clientes do Form1
            };

            // Abre o formulário
            registrosForm.ShowDialog();
        }

        private void btnApartments_Click(object sender, EventArgs e)
        {
            ApartmentForm apartmentForm = new ApartmentForm(this.Apartments) // Passa a lista de apartamentos para o construtor
            {
                Apartments = this.Apartments
            };
            apartmentForm.ShowDialog();
        }
    }
}