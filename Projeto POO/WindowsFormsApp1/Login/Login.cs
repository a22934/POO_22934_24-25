using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{   /// <summary>
    /// Formulário de login para clientes e funcionários.
    /// </summary>
    public partial class LoginForm : Form
    {
        public bool IsFuncionario { get; set; } // Adiciona a propriedade para identificar o tipo de utilizador
        public List<Client> Clients { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public List<Apartment> Apartments { get; set; }
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="LoginForm"/>.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            Clients = DataLoader.LoadClientsFromFile("Clients.json");
            Funcionarios = DataLoader.LoadFuncionariosFromFile("funcionarios.json");
            Apartments = DataLoader.LoadApartmentsFromFile("Apartments.json"); // Carrega a lista de apartamentos
        }
        /// <summary>
        /// Manipula o evento de clique do botão de login.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            LoginHandler.HandleLogin(username, password, Funcionarios, Clients, this);
        }
        /// <summary>
        /// Manipula o evento de clique do botão de registro.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            LoginHandler.HandleRegister(this);
        }
    }
}
