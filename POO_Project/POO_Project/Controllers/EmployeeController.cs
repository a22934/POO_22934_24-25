using System;
using System.Collections.Generic;
using Data;
using Models;

namespace Controllers
{
    /// <summary>
    /// Controlador responsável pela manipulação dos funcionários.
    /// </summary>
    public class EmployeeController
    {
        // Caminho do arquivo onde os dados dos funcionários são armazenados.
        private readonly string _filePath;

        /// <summary>
        /// Construtor do controlador de funcionários.
        /// Inicializa o controlador com o caminho do arquivo de dados.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo onde os dados dos funcionários serão carregados e salvos.</param>
        public EmployeeController(string filePath) => _filePath = filePath;

        /// <summary>
        /// Regista um novo funcionário.
        /// </summary>
        /// <param name="Name">Nome do funcionário.</param>
        /// <param name="EmployeeNumber">Número de identificação do funcionário.</param>
        /// <param name="password">Password do funcionário.</param>
        /// <returns>Uma tupla contendo o sucesso da operação e a mensagem de retorno.</returns>
        public (bool success, string message) RegisterEmployee(string Name, string EmployeeNumber, string password)
        {
            try
            {
                // Valida se todos os campos obrigatórios foram preenchidos.
                if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(EmployeeNumber) || string.IsNullOrWhiteSpace(password))
                    return (false, "Todos os campos são obrigatórios");

                // Valida se o número do funcionário contém apenas números.
                if (!long.TryParse(EmployeeNumber, out _))
                    return (false, "Número de funcionário deve conter apenas números");

                // Carrega a lista de funcionários existentes.
                var Employees = DataLoader.LoadFromFile<Employee>(_filePath);

                // Verifica se o número de funcionário já existe na lista.
                if (Employees.Exists(f => f.EmployeeNumber == EmployeeNumber))
                    return (false, "Número de funcionário já existe");

                // Cria um novo funcionário com os dados fornecidos.
                var newEmployee = new Employee(Name, EmployeeNumber, password);

                // Adiciona o novo funcionário à lista e salva os dados no arquivo.
                Employees.Add(newEmployee);
                DataSaver.SaveToFile(Employees, _filePath);

                return (true, "Funcionário registrado com sucesso");
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um estado de falha com a mensagem de erro.
                return (false, $"Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Remove um funcionário pela posição na lista.
        /// </summary>
        /// <param name="selectedIndex">Índice do funcionário a ser removido.</param>
        /// <returns>Uma tupla contendo o sucesso da operação e a mensagem de retorno.</returns>
        public (bool success, string message) RemoveEmployee(int selectedIndex)
        {
            try
            {
                // Carrega a lista de funcionários existentes.
                var Employees = DataLoader.LoadFromFile<Employee>(_filePath);

                // Verifica se há funcionários para remover.
                if (Employees.Count == 0)
                    return (false, "Não há funcionários para remover");

                // Verifica se o índice fornecido é válido.
                if (selectedIndex < 0 || selectedIndex >= Employees.Count)
                    return (false, "Índice inválido");

                // Remove o funcionário da lista com base no índice.
                Employees.RemoveAt(selectedIndex);

                // Salva a lista atualizada no arquivo.
                DataSaver.SaveToFile(Employees, _filePath);

                return (true, "Funcionário removido com sucesso");
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um estado de falha com a mensagem de erro.
                return (false, $"Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Lista todos os funcionários registados.
        /// </summary>
        /// <returns>Uma lista de funcionários.</returns>
        public List<Employee> ListEmployees()
        {
            // Carrega e retorna a lista de funcionários armazenados no arquivo.
            return DataLoader.LoadFromFile<Employee>(_filePath);
        }
    }
}
