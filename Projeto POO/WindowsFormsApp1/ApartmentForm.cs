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

        public ApartmentForm(List<Apartment> apartments) // Construtor que aceita a lista de apartamentos
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            LoadApartmentsFromFile();
            DisplayApartmentsInListBox();
        }

        private void DisplayApartmentsInListBox()
        {
            listBoxApartments.Items.Clear();

            foreach (var apartment in Apartments)
            {
                // Aqui adicionamos o objeto Apartment diretamente no ListBox
                listBoxApartments.Items.Add(apartment);
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
            // Verifica se algum item está selecionado no ListBox
            if (listBoxApartments.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um apartamento para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o índice do apartamento selecionado
            int selectedIndex = listBoxApartments.SelectedIndex;

            // Remove o apartamento da lista pelo índice
            if (selectedIndex >= 0 && selectedIndex < Apartments.Count)
            {
                Apartments.RemoveAt(selectedIndex); // Remove o apartamento selecionado da lista
                SaveApartmentsToFile(); // Salva a lista atualizada
                DisplayApartmentsInListBox(); // Atualiza o ListBox
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar o apartamento selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}