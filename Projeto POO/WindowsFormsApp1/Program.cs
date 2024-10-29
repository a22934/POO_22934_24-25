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

            // Exibe o formulário de login
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Se o login for bem-sucedido, abre o Form1
                Application.Run(new Form1());
            }
            else
            {
                // Fecha o aplicativo se o login falhar
                Application.Exit();
            }
        }
    }
}