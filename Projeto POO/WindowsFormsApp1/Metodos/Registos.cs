using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{       /// <summary>
        /// Classe estática responsável por registrar apartamentos, funcionários e clientes.
        /// </summary>
    public static class Registos
    {
        /// <summary>
        /// Método para registar um apartamento.
        /// </summary>
        /// <param name="apartments">Lista de apartamentos.</param>
        /// <param name="filePath">Caminho do arquivo onde os apartamentos são guardados.</param>
        /// <param name="name">Nome do apartamento.</param>
        /// <param name="location">Localização do apartamento.</param>
        /// <param name="typology">Tipologia do apartamento.</param>
        /// <param name="propertyType">Tipo de propriedade do apartamento.</param>
        /// <param name="additionalFeatures">Características adicionais do apartamento.</param>
        /// <param name="precoPorNoite">Preço por noite do apartamento.</param>
        public static void RegisterApartment(List<Apartment> apartments, string filePath, string name, string location, string typology, string propertyType, string additionalFeatures, string precoPorNoite)
        {   // Valida os campos obrigatórios
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(typology) || string.IsNullOrWhiteSpace(propertyType))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Apartment newApartment = new Apartment(name, location, typology, propertyType, additionalFeatures, precoPorNoite);

            try
            {
                List<Apartment> existingApartments = DataLoader.LoadApartmentsFromFile(filePath);
                existingApartments.Add(newApartment);
                DataSaver.SaveApartmentsToFile(existingApartments, filePath);
                MessageBox.Show("Apartamento registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar apartamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para registar um funcionário.
        /// </summary>
        /// <param name="funcionarios">Lista de funcionários.</param>
        /// <param name="filePath">Caminho do arquivo onde os funcionários são guardados.</param>
        /// <param name="nome">Nome do funcionário.</param>
        /// <param name="numeroFuncionario">Número do funcionário.</param>
        /// <param name="password">Senha do funcionário.</param>
        public static void RegisterEmployee(List<Funcionario> funcionarios, string filePath, string nome, string numeroFuncionario, string password)
        { // Valida os campos obrigatórios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(numeroFuncionario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verifica se o número de funcionário é um número
            if (!long.TryParse(numeroFuncionario, out _))
            {
                MessageBox.Show("O Número de Funcionário deve conter apenas números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Verifica se o número de funcionário já existe
            if (funcionarios.Exists(f => f.NumeroFuncionario == numeroFuncionario))
            {
                MessageBox.Show("Número de funcionário já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Funcionario newFuncionario = new Funcionario(nome, numeroFuncionario, password);

            try
            {
                List<Funcionario> existingFuncionarios = DataLoader.LoadFuncionariosFromFile(filePath);
                existingFuncionarios.Add(newFuncionario);
                DataSaver.SaveFuncionariosToFile(existingFuncionarios, filePath);
                MessageBox.Show("Funcionário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para registar um cliente.
        /// </summary>
        /// <param name="clients">Lista de clientes.</param>
        /// <param name="filePath">Caminho do arquivo onde os clientes são guardados.</param>
        /// <param name="name">Nome do cliente.</param>
        /// <param name="nif">NIF do cliente.</param>
        /// <param name="contact">Contato do cliente.</param>
        /// <param name="password">Senha do cliente.</param>
        public static void RegisterClient(List<Client> clients, string filePath, string name, string nif, string contact, string password)
        {
            // Valida os campos obrigatórios
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(nif) || string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria um novo cliente
            Client newClient = new Client(name, nif, contact, password);

            try
            {
                // Adiciona o novo cliente à lista existente
                clients.Add(newClient);

                // Salva a lista de clientes no arquivo
                DataSaver.SaveClientsToFile(clients, filePath);

                MessageBox.Show("Cliente registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
