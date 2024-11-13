using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cria o formulário de login
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
                    ClientesMenu clientesMenu = new ClientesMenu(loginForm.Apartments); // Passa a lista de apartamentos
                    Application.Run(clientesMenu); // Usa Application.Run uma vez aqui para rodar o loop de eventos
                }
            }
            else
            {
                // Caso o login falhe ou seja cancelado, a aplicação não faz nada ou termina
                Application.Exit();
            }
        }
    }
}