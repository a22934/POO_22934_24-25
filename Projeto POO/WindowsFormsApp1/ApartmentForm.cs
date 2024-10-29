using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ApartmentForm : Form
    {
        public List<Apartment> Apartments { get; set; } // Propriedade para armazenar a lista de apartamentos

        public ApartmentForm(List<Apartment> apartments) // Construtor que aceita a lista de apartamentos
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            Apartments = apartments; // Inicializa a propriedade Apartments
        }

        private void ApartmentForm_Load(object sender, EventArgs e)
        {
            LoadApartments(); // Carrega a lista de apartamentos quando o formulário é carregado
        }
        private void LoadApartments()
        {
            listBoxApartments.Items.Clear(); // Limpa a lista atual

            // Adiciona cada apartamento na lista
            if (Apartments != null && Apartments.Count > 0) // Verifica se a lista não está vazia
            {
                foreach (var apartment in Apartments)
                {
                    listBoxApartments.Items.Add(apartment.ToString()); // Adiciona a representação do apartamento
                }
            }
            else
            {
                listBoxApartments.Items.Add("Nenhum apartamento disponível."); // Mensagem quando não há apartamentos
            }
        }

        // Método para remover um apartamento
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxApartments.SelectedIndex != -1)
            {
                Apartments.RemoveAt(listBoxApartments.SelectedIndex); // Remove o apartamento selecionado
                LoadApartments(); // Atualiza a lista após remover
                MessageBox.Show("Apartamento removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um apartamento para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}