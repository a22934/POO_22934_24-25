using System;
using System.Collections.Generic;

namespace ClientManagement_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>(); // Lista de clientes
            RegistoMenu registoMenu = new RegistoMenu(clients); // Instância do menu de registo
            ClientesMenu clientesMenu = new ClientesMenu(clients); // Instância do menu de clientes

            int mainOption;

            // Menu principal
            do
            {
                Console.WriteLine("=== Client Management ===");
                Console.WriteLine("1. Registo");
                Console.WriteLine("2. Clientes");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out mainOption))
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    continue;
                }

                switch (mainOption)
                {
                    case 1:
                        registoMenu.ShowMenu(); // Chama o menu de registo
                        break;
                    case 2:
                        clientesMenu.ShowMenu(); // Chama o menu de clientes
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            } while (mainOption != 0);
        }
    }
}
