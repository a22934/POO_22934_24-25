using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterApartmentForm : Form
    {
        public List<Apartment> Apartments { get; set; }
        private readonly string filePath = "apartments.json";

        public RegisterApartmentForm()
        {
            InitializeComponent();

            // Carrega a lista de apartamentos do arquivo JSON
            Apartments = DataLoader.LoadApartmentsFromFile(filePath);
        }

        private void btnAddApartment_Click(object sender, EventArgs e)
        {
            // Obtém os dados dos campos do formulário
            string name = txtName.Text;
            string location = txtLocation.Text;
            string typology = txtTypology.Text;
            string propertyType = txtPropertyType.Text;
            string additionalFeatures = txtAdditionalFeatures.Text;
            string precoPorNoite = numPrecoPorNoite.Text;

            // Chama o método da classe Registos para registrar o apartamento
            Registos.RegisterApartment(Apartments, filePath, name, location, typology, propertyType, additionalFeatures, precoPorNoite);

            // Fecha o formulário após registrar com sucesso
             this.Close();
        }
    }
}
