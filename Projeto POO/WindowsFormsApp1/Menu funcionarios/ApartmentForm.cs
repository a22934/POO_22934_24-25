using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ApartmentForm : Form
    {
        public List<Apartment> Apartments { get; set; } // Lista de apartamentos
        private readonly string filePath = "apartments.json"; // Caminho do arquivo JSON
        private bool IsFuncionario { get; set; } // Controle de visibilidade do botão para funcionários

        public ApartmentForm(List<Apartment> apartments, bool isFuncionario)
        {
            InitializeComponent();
            Apartments = apartments;
            IsFuncionario = isFuncionario; // Atribui o valor para saber se é funcionário
            dataGridViewApartments.Columns.Add("PrecoPorNoite", "Preço por Noite");

            // Carrega os apartamentos diretamente usando DataLoader
            Apartments = DataLoader.LoadApartmentsFromFile(filePath);
            // Exibe os apartamentos no DataGridView
            DisplayApartmentsInDataGridView();
            // Se não for funcionário, esconde o botão de remoção
            if (!IsFuncionario)
            {
                btnRemoveApartment.Visible = false;
            }
        }

        // Exibe os apartamentos no DataGridView
        private void DisplayApartmentsInDataGridView()
        {
            dataGridViewApartments.Rows.Clear(); // Limpa as linhas do DataGridView antes de adicionar novas

            // Preenche o DataGridView com os apartamentos restantes
            foreach (var apartment in Apartments)
            {
                dataGridViewApartments.Rows.Add(apartment.Name, apartment.Location, apartment.Typology, apartment.PropertyType, apartment.AdditionalFeatures, apartment.PrecoPorNoite);
            }
        }

        // Evento de clique para o botão de remover apartamento
        private void btnRemoveApartment_Click(object sender, EventArgs e)
        {
            // Obtém o índice da linha selecionada
            int selectedIndex = dataGridViewApartments.SelectedCells[0].RowIndex;

            // Chama o método de remoção no Remove.cs
            Remove.RemoveApartment(Apartments, filePath, selectedIndex);

            // Atualiza o DataGridView com a lista de apartamentos atualizada após a remoção
            DisplayApartmentsInDataGridView();
        }
    }
}
