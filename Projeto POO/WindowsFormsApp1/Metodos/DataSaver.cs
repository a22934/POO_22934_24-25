using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{       /// <summary>
        /// Classe estática responsável por salvar dados em arquivos JSON.
        /// </summary>
    public static class DataSaver
    {
        /// <summary>
        /// Salva a lista de clientes no arquivo JSON.
        /// </summary>
        /// <param name="clients">Lista de clientes a ser salva.</param>
        /// <param name="filePath">Caminho do arquivo JSON.</param>
        public static void SaveClientsToFile(List<Client> clients, string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(clients, Formatting.Indented);
                File.WriteAllText(filePath, json); // Salva a lista de clientes no arquivo JSON
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


        /// <summary>
        /// Salva a lista de apartamentos no arquivo JSON.
        /// </summary>
        /// <param name="apartments">Lista de apartamentos a ser salva.</param>
        /// <param name="filePath">Caminho do arquivo JSON.</param>
        public static void SaveApartmentsToFile(List<Apartment> apartments, string filePath)
        {
            try
            {
                string updatedJson = JsonConvert.SerializeObject(apartments, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson); // Salva a lista de apartamentos no arquivo JSON
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar apartamentos: {ex.Message}");
            }
        }

        /// <summary>
        /// Salva a lista de funcionários no arquivo JSON.
        /// </summary>
        /// <param name="funcionarios">Lista de funcionários a ser salva.</param>
        /// <param name="filePath">Caminho do arquivo JSON.</param>
        public static void SaveFuncionariosToFile(List<Funcionario> funcionarios, string filePath)
        {
            try
            {
                string updatedJson = JsonConvert.SerializeObject(funcionarios, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson); // Salva a lista de funcionários no arquivo JSON
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar funcionários: {ex.Message}");
            }
        }

        private const string caminhoArquivoReservas = "reservas.json";  // Caminho fixo para as reservas

        // Método para salvar as reservas em um arquivo JSON
        public static void SalvarReservas(List<Reserva> reservas)
        {
            try
            {
                // Serializa a lista de reservas em formato JSON
                string json = JsonConvert.SerializeObject(reservas, Formatting.Indented);

                // Escreve o JSON no arquivo
                File.WriteAllText(caminhoArquivoReservas, json);
            }
            catch (Exception ex)
            {
                // Se ocorrer algum erro, você pode lançar uma exceção ou tratar da maneira que preferir
                throw new Exception($"Erro ao salvar as reservas: {ex.Message}");
            }
        }
    }
}
