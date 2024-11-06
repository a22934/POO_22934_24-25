using ClientManagement_OOP;
using System;

public class Reserva
{
    public int Id { get; set; }
    public Client Cliente { get; set; } // O cliente que fez a reserva
    public Apartment Apartamento { get; set; } // O apartamento reservado
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public bool IsCheckedIn { get; set; } = false;
    public bool IsCheckedOut { get; set; } = false;

    public Reserva(int id, Client cliente, Apartment apartamento, DateTime checkIn, DateTime checkOut)
    {
        Id = id;
        Cliente = cliente;
        Apartamento = apartamento;
        CheckInDate = checkIn;
        CheckOutDate = checkOut;
    }

    public void CheckIn() => IsCheckedIn = true;
    public void CheckOut() => IsCheckedOut = true;
}
