using System;
using System.Collections.Generic;

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
    /// <summary>
    /// Verifica se o apartamento está disponível para um periodo especifico.
    /// </summary>
    /// <param name="inicio">Data de início do período.</param>
    /// <param name="fim">Data de fim do período.</param>
    /// <returns>Retorna <c>true</c> se o apartamento estiver disponível; caso contrário, <c>false</c>.</returns>
 
    public bool IsDisponivel(DateTime inicio, DateTime fim)
    {
        foreach (var periodo in PeriodosIndisponiveis)
        {
            // Se houver interseção entre as datas solicitadas e um período de indisponibilidade, retorna falso
            if (inicio < periodo.fim && fim > periodo.inicio)
                return false;
        }
        return true;
    }

    /// <summary>
    /// Marca o apartamento como indisponivel para um período específico.
    /// </summary>
    /// <param name="inicio">Data de inicio </param>
    /// <param name="fim">Data do fim </param>
    public void MarcarIndisponivel(DateTime inicio, DateTime fim)
    {
        PeriodosIndisponiveis.Add((inicio, fim));
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