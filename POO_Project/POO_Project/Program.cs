using System;
using System.Windows.Forms;
using Controllers;
using Views;

namespace POO_Project
{
    internal static class Program
    {
        /// <summary>
        /// Método principal que inicia a aplicação, gerencia o fluxo de login e abre o formulário adequado.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Habilita estilos visuais
            Application.SetCompatibleTextRenderingDefault(false); // Define a renderização de texto compatível

            // Inicializa os controladores necessários
            var clientController = new ClientController("clients.json");
            var apartmentController = new ApartmentController("apartments.json");
            var EmployeeController = new EmployeeController("Employee.json");
            var reservaController = new ReservaController("reservas.json");
            var loginController = new LoginController(clientController, EmployeeController);

            // Cria o formulário de login
            var loginForm = new LoginForm(loginController, clientController, apartmentController, EmployeeController, reservaController);

            // Verifica se o login foi bem-sucedido
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Verifica se o usuário logado é um funcionário ou cliente
                if (loginForm.IsEmployee)
                {
                    // Se for funcionário, abre o Form1
                    var form1 = new Form1(clientController, apartmentController, EmployeeController, reservaController);
                    Application.Run(form1); // Usa Application.Run para rodar o loop de eventos
                }
                else
                {
                    // Se for cliente, abre o ClientesMenu
                    var loggedClient = loginForm.LoggedClient; // Obtém o cliente logado
                    var clientesMenu = new ClientesMenu(apartmentController, reservaController, loggedClient); // Passa o ApartmentController, ReservaController e o cliente logado para o ClientesMenu
                    Application.Run(clientesMenu); // Usa Application.Run para rodar o loop de eventos
                }
            }
            else
            {
                // Se o login falhar, fecha a aplicação
                Application.Exit();
            }
        }
    }
}