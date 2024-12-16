using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Registos
    {
        // Método para registrar um apartamento
        public static void RegisterApartment(List<Apartment> apartments, string filePath, string name, string location, string typology, string propertyType, string additionalFeatures, string precoPorNoite)
        {
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

        // Método para registrar um funcionário
        public static void RegisterEmployee(List<Funcionario> funcionarios, string filePath, string nome, string numeroFuncionario, string password)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(numeroFuncionario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(numeroFuncionario, out _))
            {
                MessageBox.Show("O Número de Funcionário deve conter apenas números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        // Método para registrar um cliente
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
