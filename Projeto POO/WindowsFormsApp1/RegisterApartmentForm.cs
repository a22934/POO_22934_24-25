using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterApartmentForm : Form
    {
        public List<Apartment> Apartments { get; set; }

        public RegisterApartmentForm()
        {
            InitializeComponent();
            LoadApartmentsFromFile();
        }

        private void btnAddApartment_Click(object sender, EventArgs e)
        {
            if (Apartments == null)
            {
                Apartments = new List<Apartment>();
            }

            string name = txtName.Text;
            string location = txtLocation.Text;
            string typology = txtTypology.Text;
            string propertyType = txtPropertyType.Text;
            string additionalFeatures = txtAdditionalFeatures.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(location) ||
                string.IsNullOrWhiteSpace(typology) || string.IsNullOrWhiteSpace(propertyType))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var apartment = new Apartment(name, location, typology, propertyType, additionalFeatures);
            Apartments.Add(apartment);

            SaveApartmentsToFile();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveApartmentsToFile()
        {
            string filePath = "apartments.json";

            try
            {
                // Carrega a lista de apartamentos existentes do arquivo JSON, se houver algum
                List<Apartment> existingApartments = new List<Apartment>();
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    existingApartments = JsonConvert.DeserializeObject<List<Apartment>>(json) ?? new List<Apartment>();
                }

                // Adiciona os novos apartamentos à lista existente
                existingApartments.AddRange(Apartments);

                // Serializa a lista completa e salva no arquivo JSON
                string updatedJson = JsonConvert.SerializeObject(existingApartments, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar apartamentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadApartmentsFromFile()
        {
            string filePath = "apartments.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    Apartments = JsonConvert.DeserializeObject<List<Apartment>>(json) ?? new List<Apartment>();
                }
                else
                {
                    Apartments = new List<Apartment>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar apartamentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Apartments = new List<Apartment>();
            }
        }
    }
}
