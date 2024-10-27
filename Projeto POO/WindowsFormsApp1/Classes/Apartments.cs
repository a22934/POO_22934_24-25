using System;

namespace ClientManagement_OOP
{
    public class Apartment
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public string Typology { get; set; } // Tipologia (T1, T2, T3)
        public string PropertyType { get; set; } // Tipo imóvel (Moradia ou Apartamento)
        public string AdditionalFeatures { get; set; } // Características adicionais

        // Construtor para inicializar um apartamento
        public Apartment(string location, string name, string typology, string propertyType, string additionalFeatures)
        {
            Location = location;
            Name = name;
            Typology = typology;
            PropertyType = propertyType;
            AdditionalFeatures = additionalFeatures;
        }

        public override string ToString()
        {
            return $"Nome: {Name}, Localização: {Location}, Tipologia: {Typology}, Tipo de Imóvel: {PropertyType}, Características Adicionais: {AdditionalFeatures}";
        }
    }
}
