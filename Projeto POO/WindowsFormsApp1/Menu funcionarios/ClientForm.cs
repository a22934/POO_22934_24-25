using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{       /// <summary>
        /// Formulário para exibir e gerenciar clientes.
        /// </summary>
    public partial class ClientForm : Form
    {
        public List<Client> Clients { get; set; } // Lista de clientes
        private readonly string filePath = "clients.json"; // Caminho do arquivo JSON

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ClientForm"/>.
        /// </summary>
        /// <param name="clients">A lista de clientes.</param>
        public ClientForm(List<Client> clients)
        {
            InitializeComponent();

            // Inicializa a lista de clientes usando o DataLoader
            Clients = DataLoader.LoadClientsFromFile(filePath);

            // Exibe os clientes no ListBox
            DisplayClientsInListBox();
        }
        /// <summary>
        /// Exibe os clientes no ListBox.
        /// </summary>
        private void DisplayClientsInListBox()
        {
            listBoxClients.Items.Clear(); // Limpa o ListBox antes de adicionar novos itens

            foreach (var client in Clients)
            {
                listBoxClients.Items.Add(client); // Adiciona diretamente o cliente no ListBox
            }
        }

        /// <summary>
        /// Evento de clique para o botão de remover cliente.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Chama o método RemoveClient da classe Remove
            Remove.RemoveClient(Clients, filePath, listBoxClients.SelectedIndex);

            // Atualiza a exibição da lista após a remoção
            DisplayClientsInListBox();
        }
    }
}
