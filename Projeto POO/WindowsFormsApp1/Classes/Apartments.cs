using System;
using System.Collections.Generic;
using System.Linq;

public class Apartment
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Typology { get; set; }
    public string PropertyType { get; set; }
    public string AdditionalFeatures { get; set; }
    public string PrecoPorNoite { get; set; }
    
    // Lista para armazenar períodos de indisponibilidade (check-ins e check-outs)
    private List<(DateTime inicio, DateTime fim)> PeriodosIndisponiveis { get; set; } = new List<(DateTime, DateTime)>();
    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="Apartment"/>.
    /// </summary>
    /// <param name="name">Nome do apartamento.</param>
    /// <param name="location">Localização do apartamento.</param>
    /// <param name="typology">Tipologia do apartamento.</param>
    /// <param name="propertyType">Tipo de propriedade do apartamento.</param>
    /// <param name="additionalFeatures">Características adicionais do apartamento.</param>
    /// <param name="precoPorNoite">Preço por noite do apartamento.</param>
    public Apartment(string name, string location, string typology, string propertyType, string additionalFeatures, string precoPorNoite)
    {
        Name = name;
        Location = location;
        Typology = typology;
        PropertyType = propertyType;
        AdditionalFeatures = additionalFeatures;
        PrecoPorNoite = precoPorNoite;
    }
    
    public bool IsDisponivel(DateTime inicio, DateTime fim, List<Reserva> reservas)
    {
        return !reservas.Any(r => r.Apartamento.Name == this.Name &&
                                  ((inicio >= r.DataInicio && inicio <= r.DataFim) ||
                                   (fim >= r.DataInicio && fim <= r.DataFim) ||
                                   (inicio <= r.DataInicio && fim >= r.DataFim)));
    }
    /// <summary>
    /// Retorna uma string que representa o apartamento.
    /// </summary>
    /// <returns>Uma string que representa o apartamento </returns> 
    public override string ToString()
    {
        return $"{Name} - {Location} - {Typology} - {PropertyType} - {AdditionalFeatures} - {PrecoPorNoite:C}";
    }
}