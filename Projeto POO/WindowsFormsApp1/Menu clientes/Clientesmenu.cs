using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement_OOP;

namespace WindowsFormsApp1
{
    public partial class ClientesMenu : Form
    {
        public List<Apartment> Apartments { get; set; }
        private List<Reserva> reservas;
        private Client loggedClient;

        public ClientesMenu(List<Apartment> apartments, Client loggedClient)
        {
            InitializeComponent();
            this.Apartments = apartments ?? new List<Apartment>();
            this.reservas = DataLoader.CarregarReservas();
            this.loggedClient = loggedClient;
        }

        private void btnListApartments_Click(object sender, EventArgs e)
        {
            ApartmentForm apartmentForm = new ApartmentForm(this.Apartments, false);
            apartmentForm.ShowDialog();
        }

        private void btnCriarReserva_Click(object sender, EventArgs e)
        {
            CriarReservaForm criarReservaForm = new CriarReservaForm(this.Apartments, this.reservas, this.loggedClient);
            criarReservaForm.ShowDialog();
        }
    }
}
