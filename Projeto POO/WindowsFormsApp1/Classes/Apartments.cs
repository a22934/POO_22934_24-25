using System;
using System.Collections.Generic;

public class Apartment
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Typology { get; set; }
    public string PropertyType { get; set; }
    public string AdditionalFeatures { get; set; }

    // Lista para armazenar períodos de indisponibilidade (check-ins e check-outs)
    private List<(DateTime inicio, DateTime fim)> PeriodosIndisponiveis { get; set; } = new List<(DateTime, DateTime)>();

    public Apartment(string name, string location, string typology, string propertyType, string additionalFeatures)
    {
        Name = name;
        Location = location;
        Typology = typology;
        PropertyType = propertyType;
        AdditionalFeatures = additionalFeatures;
    }

    // Método para verificar se o apartamento está disponível para um período específico
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

    // Método para marcar o apartamento como indisponível em um período
    public void MarcarIndisponivel(DateTime inicio, DateTime fim)
    {
        PeriodosIndisponiveis.Add((inicio, fim));
    }

    public override string ToString()
    {
        return $"{Name} - {Location} - {Typology} - {PropertyType} - {AdditionalFeatures}";
    }
}
