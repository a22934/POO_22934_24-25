using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Models;

namespace Controllers
{
    /// <summary>
    /// Controlador responsável pela manipulação dos apartamentos.
    /// </summary>
    public class ApartmentController
    {
        // Caminho do arquivo onde os dados dos apartamentos são armazenados.
        private readonly string _filePath;

        /// <summary>
        /// Construtor do controlador de apartamentos.
        /// Inicializa o controlador com o caminho do arquivo de dados.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo onde os dados dos apartamentos serão carregados e salvos.</param>
        public ApartmentController(string filePath) => _filePath = filePath;

        /// <summary>
        /// Lista todos os apartamentos armazenados.
        /// </summary>
        /// <returns>Uma lista de apartamentos.</returns>
        public List<Apartment> ListApartments()
        {
            try
            {
                // Carrega os apartamentos do arquivo e retorna a lista.
                return DataLoader.LoadFromFile<Apartment>(_filePath);
            }
            catch (Exception ex)
            {
                // Em caso de erro, lança uma exceção com uma mensagem explicativa.
                throw new Exception($"Erro ao carregar apartamentos: {ex.Message}");
            }
        }

        /// <summary>
        /// Remove um apartamento com base no índice fornecido.
        /// </summary>
        /// <param name="selectedIndex">Índice do apartamento a ser removido.</param>
        
        public (bool success, string message) RemoveApartment(int selectedIndex)
        {
            try
            {
                // Carrega a lista de apartamentos.
                var apartments = DataLoader.LoadFromFile<Apartment>(_filePath);

                // Verifica se há apartamentos para remover.
                if (apartments.Count == 0)
                    return (false, "Não há apartamentos para remover");

                // Verifica se o índice fornecido é válido.
                if (selectedIndex < 0 || selectedIndex >= apartments.Count)
                    return (false, "Índice inválido");

                // Remove o apartamento da lista.
                apartments.RemoveAt(selectedIndex);

                // Salva a lista atualizada no arquivo.
                DataSaver.SaveToFile(apartments, _filePath);

                return (true, "Apartamento removido com sucesso");
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um status de falha com a mensagem de erro.
                return (false, $"Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Regista um novo apartamento.
        /// </summary>
        /// <param name="name">Nome do apartamento.</param>
        /// <param name="location">Localização do apartamento.</param>
        /// <param name="typology">Tipologia do apartamento (e.g., "T1", "T2").</param>
        /// <param name="propertyType">Tipo de propriedade (e.g., "Casa", "Apartamento").</param>
        /// <param name="additionalFeatures">Características adicionais do apartamento.</param>
        /// <param name="PricePerNight">Preço por noite do apartamento.</param>
        /// <returns>Uma tupla contendo o sucesso da operação e a mensagem de retorno.</returns>
        public (bool success, string message) RegisterApartment(
            string name,
            string location,
            string typology,
            string propertyType,
            string additionalFeatures,
            decimal PricePerNight)
        {
            try
            {
                // Verifica se os campos obrigatórios foram preenchidos.
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(location) ||
                    string.IsNullOrWhiteSpace(typology) || string.IsNullOrWhiteSpace(propertyType))
                    return (false, "Campos obrigatórios não preenchidos");

                // Carrega a lista atual de apartamentos.
                var apartments = DataLoader.LoadFromFile<Apartment>(_filePath);

                // Cria um novo objeto Apartment com os dados fornecidos.
                var newApartment = new Apartment(name, location, typology, propertyType, additionalFeatures, PricePerNight);

                // Adiciona o novo apartamento à lista.
                apartments.Add(newApartment);

                // Salva a lista atualizada no arquivo.
                DataSaver.SaveToFile(apartments, _filePath);

                return (true, "Apartamento registrado com sucesso");
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um status de falha com a mensagem de erro.
                return (false, $"Erro: {ex.Message}");
            }
        }
    }
}
