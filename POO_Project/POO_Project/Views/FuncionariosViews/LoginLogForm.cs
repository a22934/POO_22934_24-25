using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Models;

namespace Views
{
    public partial class LoginLogForm : Form
    {
        /// <summary>
        /// Construtor da classe LoginLogForm.
        /// Inicializa o formulário e carrega o histórico de logins.
        /// </summary>
        public LoginLogForm()
        {
            InitializeComponent();
            LoadLoginLogs(); // Chama o método para carregar os logs de login.
        }

        /// <summary>
        /// Carrega e exibe os logs de login no formulário.
        /// Obtém os logs do LoginLogger e exibe cada entrada num listbox
        /// </summary>
        private void LoadLoginLogs()
        {
            // Obtém o histórico de logins armazenado no LoginLogger
            List<LoginEntry> logins = LoginLogger.GetLoginHistory();

            // Cria uma nova ListBox para exibir os logs
            ListBox listBoxLogs = new ListBox();
            listBoxLogs.Dock = DockStyle.Fill; 

            foreach (var login in logins)
            {
                listBoxLogs.Items.Add($"{login.Username} - {login.Timestamp}");
            }

            // Adiciona a ListBox ao formulário para que seja visível na interface do usuário
            this.Controls.Add(listBoxLogs);
        }
    }
}
