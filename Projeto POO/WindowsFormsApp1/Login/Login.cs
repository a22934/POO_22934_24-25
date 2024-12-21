using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public bool IsFuncionario { get; set; } // Propriedade para verificar se o utilizador logado é um funcionário
        public Client LoggedClient { get; private set; } // Propriedade para armazenar o cliente logado
        public List<Apartment> Apartments { get; private set; } // Propriedade para armazenar a lista de apartamentos
        public List<Client> Clients { get; set; } // Propriedade para armazenar a lista de clientes
        /// <summary>
        /// Inicializa uma nova instância do formulário <see cref="LoginForm"/>.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            LoadData();
        }
        /// <summary>
        /// Carrega os dados dos apartamentos e dos clientes a partir de arquivos JSON.
        /// </summary>
        private void LoadData()
        {
            string apartmentsFilePath = "Apartments.json";
            string clientsFilePath = "Clients.json";

            Apartments = DataLoader.LoadApartmentsFromFile(apartmentsFilePath);
            Clients = DataLoader.LoadClientsFromFile(clientsFilePath);
        }
        /// <summary>
        /// Lida com o evento de clique do botão de login.
        /// Valida as credenciais e autentica o utilizador (cliente ou funcionário).
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Carrega a lista de funcionários
            List<Funcionario> funcionarios = DataLoader.LoadFuncionarios();


            // Manipula o login
            LoginHandler.HandleLogin(username, password, funcionarios, Clients, this);
        }
        /// <summary>
        /// Lida com o evento de clique do botão de registro.
        /// Abre o formulário de registro ou executa a lógica de registro.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Manipula o registro
            LoginHandler.HandleRegister(this);
        }

        /// <summary>
        /// Define o cliente logado no momento.
        /// </summary>
        /// <param name="client">O cliente que será definido como logado.</param>
        public void SetLoggedClient(Client client)
        {
            this.LoggedClient = client; // Define o cliente logado
        }
    }
}
