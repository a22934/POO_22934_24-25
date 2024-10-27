using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterApartmentForm : Form
    {
        public List<Apartment> Apartments { get; set; } // Propriedade para armazenar a lista de apartamentos

        public RegisterApartmentForm()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        private void btnAddApartment_Click(object sender, EventArgs e)
        { // Inicializa a lista se for nula
            if (Apartments == null)
            {
                Apartments = new List<Apartment>();
            }

            // Obtém as informações do apartamento dos campos de texto
            string name = txtName.Text;
            string location = txtLocation.Text;
            string typology = txtTypology.Text; // Tipologia (ex: T1, T2)
            string propertyType = txtPropertyType.Text; // Tipo de Imóvel (ex: Moradia, Apartamento)
            string additionalFeatures = txtAdditionalFeatures.Text; // Características adicionais

            // Verificar campos de entrada e valores
            if (string.IsNullOrWhiteSpace(txtLocation.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtTypology.Text) || string.IsNullOrWhiteSpace(txtPropertyType.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var apartment = new Apartment(name, location, typology, propertyType, additionalFeatures);
            Apartments.Add(apartment);

            this.DialogResult = DialogResult.OK; // Define o resultado como OK
            this.Close(); // Fecha o formulário
        }


    }
}

