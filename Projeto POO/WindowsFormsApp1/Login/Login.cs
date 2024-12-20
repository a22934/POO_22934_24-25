using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public bool IsFuncionario { get; set; } // Acessor set público
        public Client LoggedClient { get; private set; } // Propriedade para armazenar o cliente logado
        public List<Apartment> Apartments { get; private set; }
        public List<Client> Clients { get; set; } // Acessor set público

        public LoginForm()
        {
            InitializeComponent();
            // Inicialize as listas de apartamentos e clientes aqui, se necessário
            LoadData();
        }

        private void LoadData()
        {
            string apartmentsFilePath = "Apartments.json";
            string clientsFilePath = "Clients.json";

            Apartments = DataLoader.LoadApartmentsFromFile(apartmentsFilePath);
            Clients = DataLoader.LoadClientsFromFile(clientsFilePath);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Supondo que você tenha uma lista de funcionários e clientes carregada
            List<Funcionario> funcionarios = DataLoader.LoadFuncionarios();


            // Manipula o login
            LoginHandler.HandleLogin(username, password, funcionarios, Clients, this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Manipula o registro
            LoginHandler.HandleRegister(this);
        }

        // Método para definir o cliente logado
        public void SetLoggedClient(Client client)
        {
            this.LoggedClient = client;
        }
    }
}
