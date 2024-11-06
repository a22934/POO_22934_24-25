using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class GestorDeReservas
{
    private List<Reserva> reservas = new List<Reserva>();
    private string filePath = "reservas.json";

    public GestorDeReservas()
    {
        LoadReservasFromFile();
    }

    // Adiciona uma reserva e salva a lista no arquivo JSON
    public void AdicionarReserva(Reserva reserva)
    {
        if (reserva.Apartamento.IsDisponivel(reserva.CheckInDate, reserva.CheckOutDate))
        {
            reservas.Add(reserva);
            reserva.Apartamento.MarcarIndisponivel(reserva.CheckInDate, reserva.CheckOutDate);
            SaveReservasToFile();
        }
        else
        {
            throw new Exception("Apartamento indisponível para as datas solicitadas.");
        }
    }

    // Obtém todas as reservas
    public List<Reserva> ObterReservas() => reservas;

    // Carrega reservas do arquivo JSON
    private void LoadReservasFromFile()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            reservas = JsonConvert.DeserializeObject<List<Reserva>>(json) ?? new List<Reserva>();
        }
    }

    // Salva reservas no arquivo JSON
    private void SaveReservasToFile()
    {
        string json = JsonConvert.SerializeObject(reservas, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public void CheckIn(int reservaId)
    {
        var reserva = reservas.Find(r => r.Id == reservaId);
        if (reserva != null) reserva.CheckIn();
        SaveReservasToFile();
    }

    public void CheckOut(int reservaId)
    {
        var reserva = reservas.Find(r => r.Id == reservaId);
        if (reserva != null) reserva.CheckOut();
        SaveReservasToFile();
    }
}
