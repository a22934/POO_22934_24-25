using System;
using System.Windows.Forms;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Classe principal que contém o ponto de entrada da aplicação.
    /// </summary>
    static class Program
    { /// <summary>
      /// Método principal que inicia a aplicação, gere o fluxo de login e abre o formulário adequado.
      /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Habilita estilos visuais
            Application.SetCompatibleTextRenderingDefault(false); // Define a renderização de texto compatível

            // Cria um formulário de login
            LoginForm loginForm = new LoginForm();

            // Verifica se o login foi bem-sucedido
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Verifica se o usuário logado é um funcionário ou cliente
                if (loginForm.IsFuncionario)
                {
                    // Se for funcionário, abre o formulário correspondente
                    Form1 form1 = new Form1();
                    Application.Run(form1); // Usa Application.Run uma vez aqui para rodar o loop de eventos
                }
                else
                {
                    // Se for cliente, abre o menu de clientes
                    Client loggedClient = loginForm.LoggedClient; // Obtém o cliente logado
                    ClientesMenu clientesMenu = new ClientesMenu(loginForm.Apartments, loggedClient); // Cria o menu de clientes
                    Application.Run(clientesMenu); // Usa Application.Run uma vez aqui para rodar o loop de eventos
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
