using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterClientForm : Form
    {
        public List<Client> Clients { get; set; } // Propriedade para armazenar a lista de clientes

        public RegisterClientForm()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string name = txtName.Text; // Obtém o nome do cliente
            string nif = txtNIF.Text; // Obtém o NIF do cliente
            string contact = txtContact.Text; // Obtém o contato do cliente

            // Valida se NIF e contato são apenas números
            if (!long.TryParse(nif, out _) || !long.TryParse(contact, out _))
            {
                MessageBox.Show("O NIF e o Contato devem conter apenas números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método se a validação falhar
            }

            // Cria um novo cliente e o adiciona à lista
            Clients.Add(new Client(name, nif, contact));
            this.DialogResult = DialogResult.OK; // Define o resultado como OK
            this.Close(); // Fecha o formulário
        }
    }
}
