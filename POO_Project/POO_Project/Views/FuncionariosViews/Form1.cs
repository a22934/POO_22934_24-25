using System;
using System.Windows.Forms;
using Controllers;
using Models;
using Views;

namespace Views
{
    /// <summary>
    /// Formulário principal da aplicação que gere a navegação entre os diversos formulários.
    /// </summary>
    public partial class Form1 : Form
    {
        private ClientController _clientController; 
        private ApartmentController _apartmentController; 
        private EmployeeController _EmployeeController; 
        private ReservaController _reservaController; 

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Form1"/>.
        /// Este é o formulário principal que gere a navegação.
        /// </summary>
        /// <param name="clientController">Controller de clientes.</param>
        /// <param name="apartmentController">Controller de apartamentos.</param>
        /// <param name="EmployeeController">Controller de funcionários.</param>
        /// <param name="reservaController">Controller de reservas.</param>
        public Form1(ClientController clientController, ApartmentController apartmentController, EmployeeController EmployeeController, ReservaController reservaController)
        {
            InitializeComponent();
            _clientController = clientController; 
            _apartmentController = apartmentController; 
            _EmployeeController = EmployeeController; 
            _reservaController = reservaController; 
        }

        /// <summary>
        /// Evento para o botão "Clientes".
        /// Abre o formulário de clientes para gerir os dados dos clientes.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnClients_Click(object sender, EventArgs e)
        {
            // Abre o formulário de clientes
            ClientForm clientForm = new ClientForm(_clientController);
            clientForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Registros".
        /// Abre o formulário de registos para gerir o registo de clientes, apartamentos e funcionários.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Abre o formulário de registos
            RegistrosForm registrosForm = new RegistrosForm(_clientController, _apartmentController, _EmployeeController);
            registrosForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Apartamentos".
        /// Abre o formulário de apartamentos para gerir a exibição e modificação de apartamentos.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnApartments_Click(object sender, EventArgs e)
        {
            // Abre o formulário de apartamentos
            ApartmentForm apartmentForm = new ApartmentForm(_apartmentController, true); // Passa 'true' para mostrar opções de gerenciamento de apartamentos para funcionários
            apartmentForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Consultas".
        /// Abre o formulário de consultas para gerir reservas e consultas de informações.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            // Abre o formulário de consultas
            ConsultaForm consultaForm = new ConsultaForm(_reservaController);
            consultaForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Check-In/Check-Out".
        /// Abre o formulário de check-in e check-out para gerir a entrada e saída de hóspedes.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnCheckInCheckOut_Click(object sender, EventArgs e)
        {
            // Abre o formulário de check-in e check-out
            CheckInCheckOutForm checkInCheckOutForm = new CheckInCheckOutForm(_reservaController);
            checkInCheckOutForm.ShowDialog();
        }

        /// <summary>
        /// Evento para o botão "Logs".
        /// Abre o formulário de logs para visualizar o histórico de login dos usuários.
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnLogs_Click(object sender, EventArgs e)
        {
            // Abre o formulário de logs
            LoginLogForm loginLogForm = new LoginLogForm();
            loginLogForm.ShowDialog();
        }
    }
}
