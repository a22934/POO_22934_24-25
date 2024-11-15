using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public bool IsFuncionario { get; private set; } // Adiciona a propriedade para identificar o tipo de usuário
        private List<Client> Clients { get; set; }
        private List<Funcionario> Funcionarios { get; set; }
        public List<Apartment> Apartments { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            LoadClientsFromFile();
            LoadFuncionariosFromFile();
            LoadApartmentsFromFile(); // Carrega a lista de apartamentos
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Verifica se o login é de um funcionário
            Funcionario funcionario = Funcionarios.Find(f => f.NumeroFuncionario == username && f.Password == password);
            if (funcionario != null)
            {
                // Login bem-sucedido de funcionário
                MessageBox.Show("Login de funcionário bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Define que o usuário logado é um funcionário
                IsFuncionario = true;

                // Define o DialogResult como OK e fecha o LoginForm
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;  // Interrompe o fluxo, pois o login foi bem-sucedido
            }

            // Caso não seja funcionário, verifica se é um cliente
            Client client = Clients.Find(c => c.Nome == username && c.Password == password);
            if (client != null)
            {
                // Login bem-sucedido de cliente
                MessageBox.Show("Login de cliente bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Define que o usuário logado não é um funcionário
                IsFuncionario = false;

                // Define o DialogResult como OK e fecha o LoginForm
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;  // Interrompe o fluxo, pois o login foi bem-sucedido
            }
            else
            {
                // Caso o login falhe para funcionário e cliente
                MessageBox.Show("Nome de usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para o clique no botão de registrar cliente
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterClientForm registerClientForm = new RegisterClientForm();
            if (registerClientForm.ShowDialog() == DialogResult.OK)
            {
                LoadClientsFromFile(); // Recarrega a lista de clientes após o registro
            }
        }

        // Método para carregar a lista de clientes do arquivo JSON
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

        // Método para carregar a lista de funcionários do arquivo JSON
        private void LoadFuncionariosFromFile()
        {
            string filePath = "funcionarios.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    Funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(json) ?? new List<Funcionario>();
                }
                else
                {
                    Funcionarios = new List<Funcionario>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Funcionarios = new List<Funcionario>();
            }
        }

        // Método para carregar a lista de apartamentos do arquivo JSON
        private void LoadApartmentsFromFile()
        {
            string filePath = "Apartments.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    Apartments = JsonConvert.DeserializeObject<List<Apartment>>(json) ?? new List<Apartment>();
                }
                else
                {
                    Apartments = new List<Apartment>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar apartamentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Apartments = new List<Apartment>();
            }
        }
    }
}
