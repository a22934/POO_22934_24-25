using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class DataSaver
    {
        // Salva a lista de clientes no arquivo JSON
        public static void SaveClientsToFile(List<Client> clients, string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(clients, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

    // Salva a lista de apartamentos no arquivo JSON
    public static void SaveApartmentsToFile(List<Apartment> apartments, string filePath)
        {
            try
            {
                string updatedJson = JsonConvert.SerializeObject(apartments, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar apartamentos: {ex.Message}");
            }
        }

        // Salva a lista de funcionários no arquivo JSON
        public static void SaveFuncionariosToFile(List<Funcionario> funcionarios, string filePath)
        {
            try
            {
                string updatedJson = JsonConvert.SerializeObject(funcionarios, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar funcionários: {ex.Message}");
            }
        }
    }
}
