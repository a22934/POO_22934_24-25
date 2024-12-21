using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{   /// <summary>
    /// Formulário para exibir e gerir apartamentos.
    /// </summary>
    public partial class ApartmentForm : Form
    {
        public List<Apartment> Apartments { get; set; } // Lista de apartamentos
        private readonly string filePath = "apartments.json"; // Caminho do arquivo JSON
        private bool IsFuncionario { get; set; } // Indica se o usuário é um funcionário
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ApartmentForm"/>.
        /// </summary>
        /// <param name="apartments">Lista de apartamentos.</param>
        /// <param name="isFuncionario">Indica se o usuário é um funcionário.</param>
        public ApartmentForm(List<Apartment> apartments, bool isFuncionario)
        {
            InitializeComponent();
            Apartments = apartments;
            IsFuncionario = isFuncionario; // Define se o usuário é um funcionário
            dataGridViewApartments.Columns.Add("PrecoPorNoite", "Preço por Noite");

            // Carrega os apartamentos do arquivo JSON
            Apartments = DataLoader.LoadApartmentsFromFile(filePath);
            // Exibe os apartamentos no DataGridView
            DisplayApartmentsInDataGridView();
            // Verifica se o usuário é um funcionário, caso contrario remove o botão de remover apartamento
            if (!IsFuncionario)
            {
                btnRemoveApartment.Visible = false;
            }
        }

        /// <summary>
        /// Exibe os apartamentos no DataGridView.
        /// </summary>
        private void DisplayApartmentsInDataGridView()
        {
            dataGridViewApartments.Rows.Clear(); // Limpa as linhas do DataGridView antes de adicionar novas

            // Preenche o DataGridView com os apartamentos restantes
            foreach (var apartment in Apartments)
            {
                dataGridViewApartments.Rows.Add(apartment.Name, apartment.Location, apartment.Typology, apartment.PropertyType, apartment.AdditionalFeatures, apartment.PrecoPorNoite);
            }
        }

        /// <summary>
        /// Evento de clique para o botão de remover apartamento.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
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
