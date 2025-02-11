using System;
using System.Windows.Forms;
using Controllers;
using Models;
using Views;

namespace Views
{
    public partial class RegistrosForm : Form
    {
        private ClientController _clientController; 
        private ApartmentController _apartmentController; 
        private EmployeeController _EmployeeController; 

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="RegistrosForm"/>.
        /// </summary>
        /// <param name="clientController">Controller de clientes.</param>
        /// <param name="apartmentController">Controller de apartamentos.</param>
        /// <param name="EmployeeController">Controller de funcionários.</param>
        public RegistrosForm(ClientController clientController, ApartmentController apartmentController, EmployeeController EmployeeController)
        {
            InitializeComponent();
            _clientController = clientController; 
            _apartmentController = apartmentController; 
            _EmployeeController = EmployeeController; 
        }

        /// <summary>
        /// Evento de clique do botão para adicionar um cliente.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Informações do evento.</param>
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Abre o formulário de registo de clientes
            RegisterClientForm registerClientForm = new RegisterClientForm(_clientController);
            registerClientForm.ShowDialog(); // Exibe o formulário para adicionar um cliente
        }

        /// <summary>
        /// Evento de clique do botão para adicionar um apartamento.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Informações do evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Abre o formulário de registo de apartamentos
            RegisterApartmentForm registerApartmentForm = new RegisterApartmentForm(_apartmentController);
            registerApartmentForm.ShowDialog(); // Exibe o formulário para adicionar um apartamento
        }

        /// <summary>
        /// Evento de clique do botão para registar um funcionário.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Informações do evento.</param>
        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            // Abre o formulário de registo de funcionários
            RegisterEmployeeForm registerEmployeeForm = new RegisterEmployeeForm(_EmployeeController);
            registerEmployeeForm.ShowDialog(); // Exibe o formulário para adicionar um funcionário
        }
    }
}
