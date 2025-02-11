using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    /// <summary>
    /// Formulário para exibição e gerenciamento de apartamentos.
    /// Permite visualizar apartamentos e, se for um funcionário, remover apartamentos.
    /// </summary>
    public partial class ApartmentForm : Form
    {
        // Controlador de apartamentos responsável por gerir operações relacionadas a apartamentos
        private readonly ApartmentController _apartmentController;

        // Variável que determina se o usuário é um funcionário (usada para habilitar/desabilitar funcionalidades)
        private readonly bool _isEmployee;

        /// <summary>
        /// Construtor da classe ApartmentForm.
        /// Inicializa o controlador de apartamentos e configura a interface de acordo com o tipo de usuário (funcionário ou cliente).
        /// </summary>
        /// <param name="apartmentController">Controlador de apartamentos.</param>
        /// <param name="isEmployee">Indica se o usuário é um funcionário.</param>
        public ApartmentForm(ApartmentController apartmentController, bool isEmployee)
        {
            InitializeComponent(); 
            _apartmentController = apartmentController; 
            _isEmployee = isEmployee; 

            // Configura a visibilidade do botão de remoção de apartamento com base no tipo de usuário
            if (_isEmployee)
            {
                btnRemoveApartment.Visible = true; 
            }
            else
            {
                btnRemoveApartment.Visible = false; 
            }

            DisplayApartmentsInDataGridView();
        }

        /// <summary>
        /// Exibe todos os apartamentos no DataGridView.
        /// Limpa as linhas existentes e preenche com os dados dos apartamentos.
        /// </summary>
        private void DisplayApartmentsInDataGridView()
        {
            dataGridViewApartments.Rows.Clear(); 

            // Obtém a lista de apartamentos através do controlador
            var apartments = _apartmentController.ListApartments();

            // Preenche o DataGridView com os apartamentos
            foreach (var apartment in apartments)
            {
                dataGridViewApartments.Rows.Add(
                    apartment.Name,             
                    apartment.Location,         
                    apartment.Typology,        
                    apartment.PropertyType,     
                    apartment.AdditionalFeatures, 
                    apartment.PricePerNight     
                );
            }
        }

        /// <summary>
        /// Método chamado quando o botão "Remover Apartamento" é utilizado.
        /// Permite ao usuário (se for um funcionário) remover um apartamento selecionado.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void btnRemoveApartment_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou um apartamento na tabela
            if (dataGridViewApartments.SelectedCells.Count == 0)
            {
                // Se não, exibe um aviso informando o erro
                MessageBox.Show("Selecione um apartamento para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o índice da linha selecionada
            int selectedIndex = dataGridViewApartments.SelectedCells[0].RowIndex;

            // Usa o controlador de apartamentos para remover o apartamento
            var result = _apartmentController.RemoveApartment(selectedIndex);

            // Verifica se a remoção foi bem-sucedida
            if (result.success)
            {
                // Se bem-sucedido, exibe mensagem de sucesso e atualiza a tabela
                MessageBox.Show(result.message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayApartmentsInDataGridView(); // Atualiza o DataGridView com a nova lista de apartamentos
            }
            else
            {
                // Se falhou, exibe uma mensagem de erro
                MessageBox.Show(result.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
