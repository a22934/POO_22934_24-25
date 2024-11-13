using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ClientForm : Form
    {
        public List<Client> Clients { get; set; } // Propriedade para armazenar a lista de clientes

        public ClientForm(List <Client> clients)
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            Clients = clients;
            LoadClientsFromFile(); // Carrega clientes ao iniciar
            DisplayClientsInListBox(); // Exibe os clientes na ListBox ao iniciar
        }

        private void DisplayClientsInListBox()
        {
            listBoxClients.Items.Clear(); // Certifique-se de que 'listBoxClients' é o nome correto

            foreach (var client in Clients)
            {
                listBoxClients.Items.Add(client); // Adiciona diretamente o cliente no ListBox
            }
        }

        private void LoadClientsFromFile()
        {
            string filePath = "clients.json"; // Caminho do arquivo JSON

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    Clients = JsonConvert.DeserializeObject<List<Client>>(json) ?? new List<Client>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clients = new List<Client>();
                }
            }
            else
            {
                Clients = new List<Client>();
            }
        }

        private void SaveClientsToFile()
        {
            string filePath = "clients.json"; // Certifique-se de que o caminho está correto

            try
            {
                string updatedJson = JsonConvert.SerializeObject(Clients, Formatting.Indented); // Serializa a lista `Clients`
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para remover um cliente
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex != -1)
            {
                Clients.RemoveAt(listBoxClients.SelectedIndex); // Remove o cliente selecionado
                SaveClientsToFile(); // Salva a lista após a remoção
                DisplayClientsInListBox(); // Atualiza a lista no ListBox
                MessageBox.Show("Cliente removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
