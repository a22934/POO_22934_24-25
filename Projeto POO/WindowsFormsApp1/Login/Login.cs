using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public bool IsFuncionario { get; set; } // Adiciona a propriedade para identificar o tipo de utilizador
        public List<Client> Clients { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public List<Apartment> Apartments { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            Clients = DataLoader.LoadClientsFromFile("Clients.json");
            Funcionarios = DataLoader.LoadFuncionariosFromFile("funcionarios.json");
            Apartments = DataLoader.LoadApartmentsFromFile("Apartments.json"); // Carrega a lista de apartamentos
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            LoginHandler.HandleLogin(username, password, Funcionarios, Clients, this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            LoginHandler.HandleRegister(this);
        }
    }
}
