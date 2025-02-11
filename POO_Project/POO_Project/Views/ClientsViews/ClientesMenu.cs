using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public partial class ClientesMenu : Form
    {
        // Controladores para gerir apartamentos e reservas
        private readonly ApartmentController _apartmentController;
        private readonly ReservaController _reservaController;

        // Cliente logado
        private readonly Client _loggedClient;

        /// <summary>
        /// Construtor da classe ClientesMenu.
        /// Inicializa os controladores e o cliente logado.
        /// </summary>
        /// <param name="apartmentController">Controlador de apartamentos.</param>
        /// <param name="reservaController">Controlador de reservas.</param>
        /// <param name="loggedClient">Cliente logado.</param>
        public ClientesMenu(ApartmentController apartmentController, ReservaController reservaController, Client loggedClient)
        {
            InitializeComponent(); 
            _apartmentController = apartmentController; 
            _reservaController = reservaController; 
            _loggedClient = loggedClient; 
        }

        /// <summary>
        /// Evento de clique no botão "Listar Apartamentos".
        /// Exibe a lista de apartamentos em um novo formulário.
        /// </summary>
        private void btnListApartments_Click(object sender, EventArgs e)
        {
            // Carrega a lista de apartamentos através do controlador
            var apartments = _apartmentController.ListApartments();

            // Cria uma nova instância do formulário ApartmentForm para exibir os apartamentos
            ApartmentForm apartmentForm = new ApartmentForm(_apartmentController, false);
            apartmentForm.ShowDialog();
        }

        /// <summary>
        /// Evento de clique no botão "Criar Reserva".
        /// Abre o formulário para criar uma nova reserva.
        /// </summary>
        private void btnCriarReserva_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário CriarReservaForm,
            // passando o controlador de apartamentos, controlador de reservas e o cliente logado
            CriarReservaForm criarReservaForm = new CriarReservaForm(_apartmentController, _reservaController, _loggedClient);

            // Exibe o formulário para criar reserva
            criarReservaForm.ShowDialog();
        }
    }
}
