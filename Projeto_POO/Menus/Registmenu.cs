using System;
using System.Collections.Generic;

namespace ClientManagement_OOP
{
    public class RegistoMenu
    {
        private List<Client> clientList;
        private RegistoCliente registo;

        public RegistoMenu(List<Client> clients)
        {
            clientList = clients;
            registo = new RegistoCliente(clientList);
        }

        public void ShowMenu()
        {
            int option;
            do
            {
                Console.WriteLine("\n=== Registo ===");
                Console.WriteLine("1. Add Client");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        registo.AddClient(); // Chama o método para adicionar cliente
                        break;
                    case 0:
                        break; // Volta ao menu principal
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            } while (option != 0);
        }
    }
}
