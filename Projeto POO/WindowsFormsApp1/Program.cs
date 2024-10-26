using ClientManagement_OOP;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1 // Confirme que o namespace coincide com o Form1.cs
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa o formulário principal
            Application.Run(new Form1());
        }
    }
}
