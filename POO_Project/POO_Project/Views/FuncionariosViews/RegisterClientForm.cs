using System;
using System.Windows.Forms;
using System.Xml.Linq;
using Controllers;
using Models;

namespace Views
{
    public partial class RegisterClientForm : Form
    {
        private readonly ClientController _clientController;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="RegisterClientForm"/>.
        /// </summary>
        /// <param name="clientController">O controller para gerenciamento de clientes.</param>
        public RegisterClientForm(ClientController clientController)
        {
            InitializeComponent();
            _clientController = clientController; 
        }

        /// <summary>
        /// Evento de clique no botão de adicionar cliente.
        /// </summary>
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Obtém os dados dos campos do formulário
            string name = txtName.Text;
            string nif = txtNIF.Text;
            string contact = txtContact.Text;
            string password = txtPassword.Text;

            // Usa o controller para registar o cliente
            var result = _clientController.RegisterClient(name, nif, contact, password);

            if (result.success)
            {
                MessageBox.Show(result.message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha o formulário após o registo bem-sucedido
            }
            else
            {
                MessageBox.Show(result.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
