using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CriarReservaForm : Form
    {
        private List<Apartment> apartments;
        private List<Reserva> reservas;
        private Client loggedClient;

        public CriarReservaForm(List<Apartment> apartments, List<Reserva> reservas, Client loggedClient)
        {
            InitializeComponent();
            this.apartments = apartments;
            this.reservas = reservas;
            this.loggedClient = loggedClient;
            PopulateApartmentsComboBox();
        }

        private void PopulateApartmentsComboBox()
        {
            cbApartments.Items.Clear();
            foreach (var apartment in apartments)
            {
                cbApartments.Items.Add(apartment.Name);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (cbApartments.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um apartamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedApartment = apartments[cbApartments.SelectedIndex];
            var dataInicio = dtpInicio.Value;
            var dataFim = dtpFim.Value;

            CriarReserva.CriarNovaReserva(loggedClient.Nome, selectedApartment, dataInicio, dataFim, reservas);
            this.Close();
        }
    }
}

