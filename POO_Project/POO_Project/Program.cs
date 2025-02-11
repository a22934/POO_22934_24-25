using System;
using System.Windows.Forms;
using Controllers;
using Views;

namespace POO_Project
{
    internal static class Program
    {
        /// <summary>
        /// M�todo principal que inicia a aplica��o, gerencia o fluxo de login e abre o formul�rio adequado.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Habilita estilos visuais
            Application.SetCompatibleTextRenderingDefault(false); // Define a renderiza��o de texto compat�vel

            // Inicializa os controladores necess�rios
            var clientController = new ClientController("clients.json");
            var apartmentController = new ApartmentController("apartments.json");
            var EmployeeController = new EmployeeController("Employee.json");
            var reservaController = new ReservaController("reservas.json");
            var loginController = new LoginController(clientController, EmployeeController);

            // Cria o formul�rio de login
            var loginForm = new LoginForm(loginController, clientController, apartmentController, EmployeeController, reservaController);

            // Verifica se o login foi bem-sucedido
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Verifica se o usu�rio logado � um funcion�rio ou cliente
                if (loginForm.IsEmployee)
                {
                    // Se for funcion�rio, abre o Form1
                    var form1 = new Form1(clientController, apartmentController, EmployeeController, reservaController);
                    Application.Run(form1); // Usa Application.Run para rodar o loop de eventos
                }
                else
                {
                    // Se for cliente, abre o ClientesMenu
                    var loggedClient = loginForm.LoggedClient; // Obt�m o cliente logado
                    var clientesMenu = new ClientesMenu(apartmentController, reservaController, loggedClient); // Passa o ApartmentController, ReservaController e o cliente logado para o ClientesMenu
                    Application.Run(clientesMenu); // Usa Application.Run para rodar o loop de eventos
                }
            }
            else
            {
                // Se o login falhar, fecha a aplica��o
                Application.Exit();
            }
        }
    }
}