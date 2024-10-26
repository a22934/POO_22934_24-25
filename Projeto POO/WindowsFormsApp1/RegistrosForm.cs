using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegistrosForm : Form
    {
        public List<Client> Clients { get; set; } // Propriedade para a lista de clientes

        public RegistrosForm()
        {
            InitializeComponent();
            Clients = new List<Client>(); // Inicializa a lista de clientes
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do RegisterClientForm
            RegisterClientForm registerClientForm = new RegisterClientForm
            {
                Clients = this.Clients // Passa a lista de clientes
            };

            // Abre o formulário e verifica se o resultado é OK
            if (registerClientForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cliente registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
