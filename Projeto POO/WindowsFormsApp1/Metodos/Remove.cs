using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Remove
    {
        // Método para remover um apartamento da lista e salvar as alterações no arquivo
        public static void RemoveApartment(List<Apartment> apartments, string filePath, int selectedIndex)
        {
            try
            {
                // Verifica se a lista de apartamentos está vazia
                if (apartments == null || apartments.Count == 0)
                {
                    MessageBox.Show("Não há apartamentos para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica se o índice selecionado é válido
                if (selectedIndex < 0 || selectedIndex >= apartments.Count)
                {
                    MessageBox.Show("Índice inválido. Selecione um apartamento válido para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Remove o apartamento da lista
                apartments.RemoveAt(selectedIndex);

                // Salva a lista de apartamentos no arquivo JSON
                DataSaver.SaveApartmentsToFile(apartments, filePath);

                MessageBox.Show("Apartamento removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover apartamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para remover um cliente da lista e salvar as alterações no arquivo
        public static void RemoveClient(List<Client> clients, string filePath, int selectedIndex)
        {
            try
            {
                // Verifica se a lista de clientes está vazia
                if (clients == null || clients.Count == 0)
                {
                    MessageBox.Show("Não há clientes para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica se o índice selecionado é válido
                if (selectedIndex < 0 || selectedIndex >= clients.Count)
                {
                    MessageBox.Show("Índice inválido. Selecione um cliente válido para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Remove o cliente da lista
                clients.RemoveAt(selectedIndex);

                // Salva a lista de clientes no arquivo JSON
                DataSaver.SaveClientsToFile(clients, filePath);

                MessageBox.Show("Cliente removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
