using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{          /// <summary>
           /// Formulário para gerir registros de clientes, apartamentos e funcionários.
           /// </summary>
    public partial class RegistrosForm : Form
    {
        public List<Client> Clients { get; set; } // Propriedade para a lista de clientes
        public List<Apartment> Apartments { get; set; } // Propriedade para armazenar a lista de apartamentos
        public List<Funcionario> Funcionarios { get; set; } // Propriedade para armazenar a lista de funcionários

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="RegistrosForm"/>.
        /// </summary>
        public RegistrosForm()
        {
            InitializeComponent();
            Clients = new List<Client>(); // Inicializa a lista de clientes
        }

        /// <summary>
        /// Evento de clique do botão para adicionar um cliente.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do RegisterClientForm e passa a lista de clientes
            RegisterClientForm registerClientForm = new RegisterClientForm(this.Clients);

            // Abre o formulário e verifica se o resultado é OK
            if (registerClientForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cliente registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Você pode chamar algum método para atualizar a lista ou o ListBox, se necessário
            
            }
        }
        /// <summary>
        /// Evento de clique do botão para adicionar um apartamento.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do RegisterClientForm
            RegisterApartmentForm registerApartmentForm = new RegisterApartmentForm
            {
                Apartments = this.Apartments // Passa a lista de clientes
            };

            // Abre o formulário e verifica se o resultado é OK
            if (registerApartmentForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Apartamento registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Evento de clique do botão para registar um funcionário.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do RegisterEmployeeForm e passa a lista de funcionários
            RegisterEmployeeForm registerEmployeeForm = new RegisterEmployeeForm(this.Funcionarios);

            // Abre o formulário e verifica se o resultado é OK
            if (registerEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Funcionário registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }

