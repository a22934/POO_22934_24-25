using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientForm : Form
    {
        public List<Client> Clients { get; set; } // Propriedade para armazenar a lista de clientes

        public ClientForm()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClients(); // Carrega a lista de clientes quando o formulário é carregado
        }

        private void LoadClients()
        {
            listBoxClients.Items.Clear(); // Limpa a lista atual

            // Adiciona cada cliente na lista
            foreach (var client in Clients)
            {
                listBoxClients.Items.Add(client.ToString());
            }
        }

        // Método para remover um cliente
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex != -1)
            {
                Clients.RemoveAt(listBoxClients.SelectedIndex); // Remove o cliente selecionado
                LoadClients(); // Atualiza a lista após remover
                MessageBox.Show("Cliente removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
