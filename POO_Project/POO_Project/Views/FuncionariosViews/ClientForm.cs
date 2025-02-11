using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public partial class ClientForm : Form
    {
        private ClientController _clientController; // Controller para Gerir clientes
        private List<Client> _clients; // Lista de clientes

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ClientForm"/>.
        /// </summary>
        /// <param name="clientController">Controller de clientes.</param>
        public ClientForm(ClientController clientController)
        {
            InitializeComponent();
            _clientController = clientController; // Recebe o controller diretamente
            _clients = _clientController.ListClients(); // Carrega a lista de clientes
            DisplayClientsInListBox(); // Exibe os clientes no ListBox
        }

        /// <summary>
        /// Exibe os clientes no ListBox.
        /// </summary>
        private void DisplayClientsInListBox()
        {
            listBoxClients.Items.Clear(); // Limpa a lista de clientes

            foreach (var client in _clients)
            {
                listBoxClients.Items.Add(client); // Adiciona o cliente à lista
            }
        }

        /// <summary>
        /// Evento de clique para o botão de remover cliente.
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex >= 0) // Verifica se um cliente foi selecionado
            {
                int selectedIndex = listBoxClients.SelectedIndex;

                // Remove o cliente usando o controller
                var result = _clientController.RemoveClient(selectedIndex);

                if (result.success)
                {
                    MessageBox.Show(result.message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _clients = _clientController.ListClients(); // Atualiza a lista de clientes
                    DisplayClientsInListBox(); // Recarrega a lista no ListBox
                }
                else
                {
                    MessageBox.Show(result.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}