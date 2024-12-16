using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientForm : Form
    {
        public List<Client> Clients { get; set; } // Lista de clientes
        private readonly string filePath = "clients.json"; // Caminho do arquivo JSON

        public ClientForm(List<Client> clients)
        {
            InitializeComponent();

            // Inicializa a lista de clientes usando o DataLoader
            Clients = DataLoader.LoadClientsFromFile(filePath);

            // Exibe os clientes no ListBox
            DisplayClientsInListBox();
        }

        private void DisplayClientsInListBox()
        {
            listBoxClients.Items.Clear(); // Limpa o ListBox antes de adicionar novos itens

            foreach (var client in Clients)
            {
                listBoxClients.Items.Add(client); // Adiciona diretamente o cliente no ListBox
            }
        }

        // Botão para remover cliente
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Chama o método RemoveClient da classe Remove
            Remove.RemoveClient(Clients, filePath, listBoxClients.SelectedIndex);

            // Atualiza a exibição da lista após a remoção
            DisplayClientsInListBox();
        }
    }
}
