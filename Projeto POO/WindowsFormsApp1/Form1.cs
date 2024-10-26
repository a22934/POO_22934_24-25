using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Client> clients = new List<Client>();

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
    }
}
