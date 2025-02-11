using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Apartment
    {   /// <summary>
        /// Nome do apartamento
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Localização do apartamento (ex: Lisboa, Porto, etc)
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Tipologia do apartamento (ex: T0, T1, etc)
        /// </summary>
        public string Typology { get; set; }
        /// <summary>
        /// Tipo de propriedade (ex: Apartamento, Casa, etc)
        /// </summary>
        public string PropertyType { get; set; }
        /// <summary>
        /// Características adicionais (ex: Piscina, Ar Condicionado, etc)
        /// </summary>
        public string AdditionalFeatures { get; set; }
        /// <summary>
        /// Preço por noite do apartamento
        /// </summary>
        public decimal PricePerNight { get; set; } 
        /// <summary>
        /// Períodos indisponíveis 
        /// </summary>
        private List<(DateTime Start, DateTime End)> UnavailablePeriods { get; set; } = new List<(DateTime, DateTime)>();
        /// <summary>
        /// Construtor da classe Apartment.
        /// </summary>
        /// <param name="name">Nome do apartamento.</param>
        /// <param name="location">Localização do apartamento.</param>
        /// <param name="typology">Tipologia do apartamento.</param>
        /// <param name="propertyType">Tipo de propriedade.</param>
        /// <param name="additionalFeatures">Características adicionais.</param>
        /// <param name="pricePerNight">Preço por noite.</param>
        public Apartment(string name, string location, string typology, string propertyType, string additionalFeatures, decimal pricePerNight)
        {
            Name = name;
            Location = location;
            Typology = typology;
            PropertyType = propertyType;
            AdditionalFeatures = additionalFeatures;
            PricePerNight = pricePerNight;
        }
        /// <summary>
        /// Verifica se o apartamento está disponível para reserva num determinado período.
        /// </summary>
        /// <param name="Start">Data de início da reserva.</param>
        /// <param name="End">Data de término da reserva.</param>
        /// <param name="reservas">Lista de reservas já feitas.</param>
        /// <returns>Retorna verdadeiro se o apartamento estiver disponível, caso contrário, falso.</returns>
        public bool IsAvailable(DateTime Start, DateTime End, List<Reserva> reservas)
        {
            return !reservas.Any(r => r.Apartament.Name == this.Name &&
                ((Start >= r.StartDate && Start <= r.EndDate) ||
                 (End >= r.StartDate && End <= r.EndDate) ||
                 (Start <= r.StartDate && End >= r.EndDate)));
        }
        /// <summary>
        /// Retorna uma representação textual do apartamento.
        /// </summary>
        /// <returns>Uma string que contem informações principais do apartamento.</returns>
        public override string ToString()
        {
            return $"{Name} - {Location} - {Typology} - {PropertyType} - {AdditionalFeatures} - {PricePerNight:C}";
        }
    }
}