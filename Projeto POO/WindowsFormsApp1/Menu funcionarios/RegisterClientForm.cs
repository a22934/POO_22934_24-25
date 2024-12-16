using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterClientForm : Form
    {
        public List<Client> Clients { get; set; }
        private readonly string filePath = "clients.json"; // Caminho do arquivo JSON

        public RegisterClientForm(List<Client> clients)
        {
            InitializeComponent();
            Clients = clients;
        }

        // Evento de clique do botão para registrar um cliente
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string name = txtName.Text; // Obtém o nome do cliente
            string nif = txtNIF.Text; // Obtém o NIF do cliente
            string contact = txtContact.Text; // Obtém o contato do cliente
            string password = txtPassword.Text; // Obtém a senha do cliente

            // Carrega a lista de clientes existente do arquivo
            List<Client> existingClients = DataLoader.LoadClientsFromFile(filePath);

            // Chama o método RegisterClient de Registos, passando a lista de clientes carregada
            Registos.RegisterClient(existingClients, filePath, name, nif, contact, password);

            // Atualiza a exibição da lista de clientes no formulário
            this.Close();
        }
    }
}
