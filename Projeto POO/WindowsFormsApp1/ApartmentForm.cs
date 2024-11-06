using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ApartmentForm : Form
    {
        public List<Apartment> Apartments { get; set; } // Propriedade para armazenar a lista de apartamentos
        private GestorDeReservas gestorDeReservas = new GestorDeReservas();

        public ApartmentForm(List<Apartment> apartments) // Construtor que aceita a lista de apartamentos
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            Apartments = apartments;
            LoadApartmentsFromFile();
            DisplayApartmentsInDataGridView();
        }

        private void DisplayApartmentsInDataGridView()
        {
            dataGridViewApartments.Rows.Clear(); // Limpa as linhas do DataGridView antes de adicionar novas

            // Preenche o DataGridView com os apartamentos restantes
            foreach (var apartment in Apartments)
            {
                dataGridViewApartments.Rows.Add(apartment.Name, apartment.Location, apartment.Typology, apartment.PropertyType, apartment.AdditionalFeatures);
            }
        }

        private void LoadApartmentsFromFile()
        {
            string filePath = "apartments.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    Apartments = JsonConvert.DeserializeObject<List<Apartment>>(json) ?? new List<Apartment>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar apartamentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Apartments = new List<Apartment>();
                }
            }
            else
            {
                Apartments = new List<Apartment>();
            }
        }

        private void SaveApartmentsToFile()
        {
            string filePath = "apartments.json";

            try
            {
                string updatedJson = JsonConvert.SerializeObject(Apartments, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar apartamentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveApartment_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou uma linha
            if (dataGridViewApartments.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um apartamento para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o índice da linha selecionada, utilizando SelectedCells
            int selectedIndex = dataGridViewApartments.SelectedCells[0].RowIndex;

            // Verifica se o índice está dentro dos limites da lista de apartamentos
            if (selectedIndex >= 0 && selectedIndex < Apartments.Count)
            {
                // Remove o apartamento da lista de apartamentos com base no índice
                Apartments.RemoveAt(selectedIndex);

                // Salva a lista atualizada de apartamentos no arquivo JSON
                SaveApartmentsToFile();

                // Atualiza o DataGridView para refletir as alterações
                DisplayApartmentsInDataGridView();
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar o apartamento selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

