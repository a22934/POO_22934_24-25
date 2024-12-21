using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Classe estática responsável por carregar dados de arquivos JSON.
    /// </summary>
    public static class DataLoader
    {
        /// <summary>
        /// Carrega a lista de clientes a partir do arquivo JSON.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo JSON.</param>
        /// <returns>Uma lista de objetos <see cref="Client"/>.</returns>
        public static List<Client> LoadClientsFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<Client>>(json) ?? new List<Client>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Client>(); // Retorna uma lista vazia em caso de erro
                }
            }
            else
            {
                return new List<Client>(); // Retorna uma lista vazia se o arquivo não existir
            }
        }

        /// <summary>
        /// Carrega a lista de apartamentos a partir do arquivo JSON.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo JSON.</param>
        /// <returns>Uma lista de objetos <see cref="Apartment"/>.</returns>
        public static List<Apartment> LoadApartmentsFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<Apartment>>(json) ?? new List<Apartment>();
                }
                return new List<Apartment>(); // Retorna uma lista vazia se o arquivo não existir
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar apartamentos: {ex.Message}");
            }
        }

        /// <summary>
        /// Carrega a lista de funcionários a partir do arquivo JSON.
        /// </summary>
        /// <returns>Uma lista de objetos <see cref="Funcionario"/>.</returns>
        public static List<Funcionario> LoadFuncionarios()
        {
            string filePath = "Funcionarios.json";
            return LoadFuncionariosFromFile(filePath);
        }

        /// <summary>
        /// Carrega a lista de clientes a partir do arquivo JSON.
        /// </summary>
        /// <returns>Uma lista de objetos <see cref="Client"/>.</returns>
        public static List<Client> LoadClients()
        {
            string filePath = "Clients.json";
            return LoadClientsFromFile(filePath);
        }

        /// <summary>
        /// Carrega a lista de funcionários a partir do arquivo JSON.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo JSON.</param>
        /// <returns>Uma lista de objetos <see cref="Funcionario"/>.</returns>
        public static List<Funcionario> LoadFuncionariosFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<Funcionario>>(json) ?? new List<Funcionario>();
                }
                return new List<Funcionario>(); // Retorna uma lista vazia se o arquivo não existir
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar funcionários: {ex.Message}");
            }
        }

        private const string caminhoArquivoReservas = "reservas.json";  // Caminho fixo para as reservas

        /// <summary>
        /// Carrega as reservas a partir de um arquivo JSON.
        /// </summary>
        /// <returns>
        /// Uma lista de reservas carregada do arquivo. Retorna uma lista vazia
        /// se o arquivo não existir ou se não houver reservas armazenadas.
        /// </returns>
        public static List<Reserva> CarregarReservas()
        {
            if (!File.Exists(caminhoArquivoReservas))
            {
                return new List<Reserva>();  // Retorna uma lista vazia se o arquivo não existir
            }

            string json = File.ReadAllText(caminhoArquivoReservas);
            return JsonConvert.DeserializeObject<List<Reserva>>(json) ?? new List<Reserva>();
        }
    }

}
