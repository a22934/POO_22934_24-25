using System;
using System.Windows.Forms;
using System.Xml.Linq;
using Controllers;
using Models;

namespace Views
{
    public partial class RegisterApartmentForm : Form
    {
        private ApartmentController _apartmentController; // Controller para Gerir apartamentos

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="RegisterApartmentForm"/>.
        /// </summary>
        /// <param name="apartmentController">O controller de apartamentos.</param>
        public RegisterApartmentForm(ApartmentController apartmentController)
        {
            InitializeComponent();
            _apartmentController = apartmentController; 
        }

        /// <summary>
        /// Evento de clique para o botão de adicionar apartamento.
        /// </summary>
        private void btnAddApartment_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string location = txtLocation.Text;
            string typology = txtTypology.Text;
            string propertyType = txtPropertyType.Text;
            string additionalFeatures = txtAdditionalFeatures.Text;
            decimal PricePerNight;

            // Valida o preço por noite
            if (!decimal.TryParse(numPricePerNight.Text, out PricePerNight))
            {
                MessageBox.Show("Preço por noite inválido. Insira um valor numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Regista o apartamento usando o controller
            var result = _apartmentController.RegisterApartment(name, location, typology, propertyType, additionalFeatures, PricePerNight);

            if (result.success)
            {
                MessageBox.Show(result.message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha o formulário após o registo bem-sucedido
            }
            else
            {
                MessageBox.Show(result.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}