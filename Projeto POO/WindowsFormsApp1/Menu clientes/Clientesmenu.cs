using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{       /// <summary>
        /// Formulário de menu para clientes.
        /// </summary>
    public partial class ClientesMenu : Form
    {
        /// <summary>
        /// Define a lista de apartamentos.
        /// </summary>
        public List<Apartment> Apartments { get; set; }
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ClientesMenu"/>.
        /// </summary>
        /// <param name="apartments">Lista de apartamentos.</param>
        public ClientesMenu(List<Apartment> apartments)
        {
            InitializeComponent();
            this.Apartments = apartments ?? new List<Apartment>(); // Inicializa com uma lista vazia se null
        }
        /// <summary>
        /// Manipula o evento de clique do botão para listar apartamentos.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnListApartments_Click(object sender, EventArgs e)
        {
            // Abre o ApartmentForm e passa a lista de apartamentos
            ApartmentForm apartmentForm = new ApartmentForm(this.Apartments, false);
            apartmentForm.ShowDialog();
        }
    }
}
