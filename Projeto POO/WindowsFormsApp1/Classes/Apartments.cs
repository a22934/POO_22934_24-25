using System;
using System.Collections.Generic;
using System.Linq;

public class Apartment
{
    public string Name { get; set; }   //Obtem ou define o nome do apartamento
    public string Location { get; set; } //Obtem ou define a localização do apartamento
    public string Typology { get; set; } //Obtem ou define a tipologia do apartamento
    public string PropertyType { get; set; } //Obtem ou define o tipo de propriedade do apartamento
    public string AdditionalFeatures { get; set; } //Obtem ou define as características adicionais do apartamento
    public string PrecoPorNoite { get; set; } //Obtem ou define o preço por noite do apartamento

    /// <summary>
    /// Lista de períodos de indisponibilidade do apartamento (check-ins e check-outs).
    /// </summary>
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
    /// <summary>
    /// Verifica se o apartamento está disponível para o período escolhido.
    /// </summary>
    /// <param name="inicio">Data de início do período.</param>
    /// <param name="fim">Data de fim do período.</param>
    /// <param name="reservas">Lista de reservas existentes.</param>
    /// <returns>Verdadeiro se o apartamento estiver disponível; caso contrário, falso.</returns>
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