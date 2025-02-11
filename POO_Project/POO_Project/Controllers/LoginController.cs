using System;
using System.IO;
using System.Linq;
using Models;
using Controllers;

namespace Controllers
{
    /// <summary>
    /// Controlador responsável pela autenticação de users (clientes e funcionários).
    /// </summary>
    public class LoginController
    {
        // Controladores usados para acessar dados de clientes e funcionários
        private readonly ClientController _clientController;
        private readonly EmployeeController _EmployeeController;

        // Controlador de logs de login, para registar as tentativas de login
        private readonly LoginLogController _loginLogController;

        // Caminho do arquivo de funcionários
        private readonly string _employeeFile = "Employee.json";

        /// <summary>
        /// Construtor para inicializar o controlador de login.
        /// </summary>
        /// <param name="clientController">Controlador de clientes para validação de login de clientes.</param>
        /// <param name="EmployeeController">Controlador de funcionários para validação de login de funcionários.</param>
        public LoginController(ClientController clientController, EmployeeController EmployeeController)
        {
            _clientController = clientController;
            _EmployeeController = EmployeeController;
            _loginLogController = new LoginLogController(); // Inicializa o controlador de logs de login
        }

        /// <summary>
        /// Realiza a autenticação do user (cliente ou funcionário).
        /// </summary>
        /// <param name="username">Nome de user (ou número de funcionário para funcionários).</param>
        /// <param name="password">Password do user.</param>
        /// <returns>Uma tupla contendo o sucesso da autenticação, uma mensagem e informações sobre o tipo de user (funcionário ou cliente).</returns>
        public (bool success, string message, bool isEmployee, object? usuario) Authenticate(string username, string password)
        {
            // Verifica se o arquivo de funcionários não existe e permite credenciais padrão para o funcionário.
            if (!File.Exists(_employeeFile) && username == "0000" && password == "admin")
            {
                _loginLogController.RegisterLogin(username); // Regista o login do funcionário.
                return (true, "Login de administrador bem-sucedido!", true, new { EmployeeNumber = username });
            }

            // Verifica se o funcionário existe com as credenciais fornecidas
            var Employee = _EmployeeController.ListEmployees()
                .FirstOrDefault(f => f.EmployeeNumber == username && f.Password == password);

            if (Employee != null)
            {
                _loginLogController.RegisterLogin(username); // Registra o login do funcionário
                return (true, "Login de funcionário bem-sucedido!", true, Employee);
            }

            // Verifica se o cliente existe com as credenciais fornecidas
            var client = _clientController.ListClients()
                .FirstOrDefault(c => c.Name == username && c.Password == password);

            if (client != null)
            {
                _loginLogController.RegisterLogin(username); // Regista o login do cliente
                return (true, "Login de cliente bem-sucedido!", false, client);
            }

            // Caso o usuário ou senha sejam inválidos
            return (false, "Usuário ou senha incorretos.", false, null);
        }
    }
}
