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
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Form1"/>.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para o botão "Clientes".
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(this.clients);
            clientForm.ShowDialog();
        }
        /// <summary>
        /// Evento para o botão "Registros".
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário RegistrosForm
            RegistrosForm registrosForm = new RegistrosForm 
            {
                Clients = this.clients // Passa a lista de clientes do Form1
            };

            // Abre o formulário
            registrosForm.ShowDialog();
        }
        /// <summary>
        /// Evento para o botão "Apartamentos".
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnApartments_Click(object sender, EventArgs e)
        {
            ApartmentForm apartmentForm = new ApartmentForm(this.Apartments, true); // Passa a lista de apartamentos para o construtor
            apartmentForm.ShowDialog();
        }
    }
}