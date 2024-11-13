using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class RegisterClientForm : Form
    {
        public List<Client> Clients { get; set; } // Propriedade para armazenar a lista de clientes

        public RegisterClientForm()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            LoadClientsFromFile();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string name = txtName.Text; // Obtém o nome do cliente
            string nif = txtNIF.Text; // Obtém o NIF do cliente
            string contact = txtContact.Text; // Obtém o contato do cliente
            string password = txtPassword.Text; // Obtém a senha do cliente

            // Valida se NIF e contato são apenas números
            if (!long.TryParse(nif, out _) || !long.TryParse(contact, out _))
            {
                MessageBox.Show("O NIF e o Contato devem conter apenas números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método se a validação falhar
            }

            // Cria um novo cliente e o adiciona à lista
            Clients.Add(new Client(name, nif, contact, password));

            SaveClientsToFile(); // Salva a lista atualizada no arquivo
            this.DialogResult = DialogResult.OK; // Define o resultado como OK
            this.Close(); // Fecha o formulário
        }

        private void SaveClientsToFile()
        {
            string filePath = "Clients.json";

            try
            {
                // Carrega os clientes existentes do arquivo JSON
                List<Client> existingClients = new List<Client>();
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    existingClients = JsonConvert.DeserializeObject<List<Client>>(json) ?? new List<Client>();
                }

                // Adiciona os novos clientes à lista existente
                existingClients.AddRange(Clients);

                // Serializa a lista completa e salva no arquivo JSON
                string updatedJson = JsonConvert.SerializeObject(existingClients, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClientsFromFile()
        {
            string filePath = "Clients.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    Clients = JsonConvert.DeserializeObject<List<Client>>(json) ?? new List<Client>();
                }
                else
                {
                    Clients = new List<Client>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clients = new List<Client>();
            }
        }
    }
}