using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Models;

namespace Controllers
{
    /// <summary>
    /// Controlador responsável pela manipulação dos clientes.
    /// </summary>
    public class ClientController
    {
        // Caminho do arquivo onde os dados dos clientes são armazenados.
        private readonly string _filePath;

        /// <summary>
        /// Construtor do controlador de clientes.
        /// Inicializa o controlador com o caminho do arquivo de dados.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo onde os dados dos clientes serão carregados e salvos.</param>
        public ClientController(string filePath) => _filePath = filePath;

        /// <summary>
        /// Regista um novo cliente.
        /// </summary>
        /// <param name="name">Nome do cliente.</param>
        /// <param name="nif">Número de identificação fiscal do cliente (NIF).</param>
        /// <param name="contact">Informações de contacto do cliente.</param>
        /// <param name="password">Password do cliente.</param>
        /// <returns>Uma tupla contendo o sucesso da operação e a mensagem de retorno.</returns>
        public (bool success, string message) RegisterClient(
            string name,
            string nif,
            string contact,
            string password)
        {
            try
            {
                // Valida se todos os campos obrigatórios foram preenchidos.
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(nif) ||
                    string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(password))
                    return (false, "Todos os campos são obrigatórios");

                // Carrega a lista de clientes existentes.
                var clients = DataLoader.LoadFromFile<Client>(_filePath);

                // Verifica se o NIF já foi registado.
                if (clients.Any(c => c.NIF == nif))
                    return (false, "NIF já registrado");

                // Cria um novo cliente com os dados fornecidos.
                var newClient = new Client(name, nif, contact, password);

                // Adiciona o novo cliente à lista e salva os dados no arquivo.
                clients.Add(newClient);
                DataSaver.SaveToFile(clients, _filePath);

                return (true, "Cliente registrado com sucesso");
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um estado de falha com a mensagem de erro.
                return (false, $"Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Remove um cliente pela posição na lista.
        /// </summary>
        /// <param name="selectedIndex">Índice do cliente a ser removido.</param>
        /// <returns>Uma tupla contendo o sucesso da operação e a mensagem de retorno.</returns>
        public (bool success, string message) RemoveClient(int selectedIndex)
        {
            try
            {
                // Carrega a lista de clientes existentes.
                var clients = DataLoader.LoadFromFile<Client>(_filePath);

                // Verifica se há clientes para remover.
                if (clients.Count == 0)
                    return (false, "Não há clientes para remover");

                // Verifica se o índice fornecido é válido.
                if (selectedIndex < 0 || selectedIndex >= clients.Count)
                    return (false, "Índice inválido");

                // Remove o cliente da lista com base no índice.
                clients.RemoveAt(selectedIndex);

                // Salva a lista atualizada no arquivo.
                DataSaver.SaveToFile(clients, _filePath);

                return (true, "Cliente removido com sucesso");
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um status de falha com a mensagem de erro.
                return (false, $"Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Lista todos os clientes registados.
        /// </summary>
        /// <returns>Uma lista de clientes.</returns>
        public List<Client> ListClients()
        {
            // Carrega e retorna a lista de clientes armazenados no arquivo.
            return DataLoader.LoadFromFile<Client>(_filePath);
        }
    }
}
