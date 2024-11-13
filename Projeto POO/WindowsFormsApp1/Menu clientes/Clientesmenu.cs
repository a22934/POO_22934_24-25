using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientesMenu : Form
    {
        // Define a lista de apartamentos
        public List<Apartment> Apartments { get; set; }

        public ClientesMenu(List<Apartment> apartments)
        {
            InitializeComponent();
            this.Apartments = apartments ?? new List<Apartment>(); // Inicializa com uma lista vazia se null
        }

        private void btnListApartments_Click(object sender, EventArgs e)
        {
            // Abre o ApartmentForm e passa a lista de apartamentos
            ApartmentForm apartmentForm = new ApartmentForm(this.Apartments, false);
            apartmentForm.ShowDialog();
        }
    }
}
