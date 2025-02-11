using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    /// <summary>
    /// Formulário para login de usuários (clientes e funcionários).
    /// Possibilita que um cliente ou funcionário realize login no sistema.
    /// </summary>
    public partial class LoginForm : Form
    {
        
        private readonly LoginController _loginController;
        private readonly ClientController _clientController;
        private readonly ApartmentController _apartmentController;
        private readonly EmployeeController _EmployeeController;
        private readonly ReservaController _reservaController;

        // Propriedade que indica se o usuário logado é um funcionário
        public bool IsEmployee { get; private set; } = false;

        // Cliente logado, caso o login seja de um cliente
        public Client? LoggedClient { get; private set; } = null;

        /// <summary>
        /// Construtor da classe LoginForm.
        /// Inicializa os controladores necessários para o login.
        /// </summary>
        /// <param name="loginController">Controlador de login responsável pela autenticação.</param>
        /// <param name="clientController">Controlador de clientes.</param>
        /// <param name="apartmentController">Controlador de apartamentos.</param>
        /// <param name="EmployeeController">Controlador de funcionários.</param>
        /// <param name="reservaController">Controlador de reservas.</param>
        public LoginForm(
            LoginController loginController,
            ClientController clientController,
            ApartmentController apartmentController,
            EmployeeController EmployeeController,
            ReservaController reservaController)
        {
            InitializeComponent(); 
            _loginController = loginController; 
            _clientController = clientController; 
            _apartmentController = apartmentController; 
            _EmployeeController = EmployeeController; 
            _reservaController = reservaController; 
        }

        /// <summary>
        /// Evento chamado ao clicar no botão de login.
        /// Realiza a autenticação do usuário baseado no nome de usuário e senha fornecidos.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento (botão de login).</param>
        /// <param name="e">Dados do evento.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text;
            string password = txtPassword.Text;

        
            var authResult = _loginController.Authenticate(username, password);

            // Verifica se a autenticação foi bem-sucedida
            if (authResult.success)
            {
                if (authResult.isEmployee)
                {
                    // Caso o login seja de um funcionário
                    IsEmployee = true; 
                    MessageBox.Show("Login de funcionário bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close(); 
                }
                else
                {
                    // Caso o login seja de um cliente
                    LoggedClient = authResult.usuario as Client; 
                    if (LoggedClient != null)
                    {
                        MessageBox.Show("Login de cliente bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; 
                        this.Close(); 
                    }
                    else
                    {
                        // Caso haja erro ao converter o usuário para cliente
                        MessageBox.Show("Erro ao converter o usuário para cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Caso a autenticação falhe, exibe a mensagem de erro
                MessageBox.Show(authResult.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento chamado ao clicar no botão de registo de novo cliente.
        /// Abre o formulário para registar um novo cliente.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento (botão de registro).</param>
        /// <param name="e">Dados do evento.</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Abre o formulário para registrar um novo cliente
            RegisterClientForm registerForm = new RegisterClientForm(_clientController);
            registerForm.ShowDialog(); // Exibe o formulário de registro de cliente
        }
    }
}
