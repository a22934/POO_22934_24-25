using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{       /// <summary>
        /// Formulário para registar novos apartamentos.
        /// </summary>
    public partial class RegisterApartmentForm : Form
    {
        public List<Apartment> Apartments { get; set; } // Lista de apartamentos
        private readonly string filePath = "apartments.json"; // Caminho do arquivo JSON

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="RegisterApartmentForm"/>.
        /// </summary>
        public RegisterApartmentForm()
        {
            InitializeComponent();

            // Carrega a lista de apartamentos do arquivo JSON
            Apartments = DataLoader.LoadApartmentsFromFile(filePath);
        }
        /// <summary>
        /// Evento de clique para o botão de adicionar apartamento.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnAddApartment_Click(object sender, EventArgs e)
        {
            // Obtém os dados dos campos do formulário
            string name = txtName.Text;
            string location = txtLocation.Text;
            string typology = txtTypology.Text;
            string propertyType = txtPropertyType.Text;
            string additionalFeatures = txtAdditionalFeatures.Text;
            string precoPorNoite = numPrecoPorNoite.Text;

            // Chama o método da classe Registos para registar o apartamento
            Registos.RegisterApartment(Apartments, filePath, name, location, typology, propertyType, additionalFeatures, precoPorNoite);

            // Fecha o formulário após registar com sucesso
             this.Close();
        }
    }
}
