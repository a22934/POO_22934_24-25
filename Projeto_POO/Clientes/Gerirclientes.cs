
using System;
using System.Collections.Generic;

namespace ClientManagement_OOP
{
    public class ManageClients
    {
        private List<Client> clientList = new List<Client>();

        // Method to add a new client
        public void AddClient()
        {
            Console.WriteLine("\n--- Add Client ---");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            string nif;
            do
            {
                Console.Write("NIF (apenas números): ");
                nif = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nif) || !IsAllDigits(nif)); // Valida a entrada do NIF

            string contact;
            do
            {
                Console.Write("Contacto (apenas números): ");
                contact = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(contact) || !IsAllDigits(contact)); // Valida a entrada do Contacto


            // Creates a new client with the entered data
            Client newClient = new Client(name, nif, contact);
            clientList.Add(newClient); // Adds the client to the list

            Console.WriteLine("Client added successfully!\n");
        }

        // Method to list the registered clients
        public void ViewClients()
        {
            Console.WriteLine("\n--- List of Clients ---");

            if (clientList.Count == 0)
            {
                Console.WriteLine("No clients registered.");
            }
            else
            {
                foreach (var client in clientList)
                {
                    Console.WriteLine(client); // Calls the ToString() method of the client
                }
            }
            Console.WriteLine(); // Blank line for spacing
        }

        // Método para verificar se uma string contém apenas dígitos
        private bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c)) // Verifica se cada caractere é um dígito
                {
                    return false; // Retorna falso se encontrar um não dígito
                }
            }
            return true; // Retorna verdadeiro se todos os caracteres forem dígitos
        }
    }
    // Método para verificar se uma string contém apenas dígitos
    private bool IsAllDigits(string input)
    {
        // Verifica se a entrada não é nula ou vazia
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        foreach (char c in input)
        {
            if (!char.IsDigit(c)) // Verifica se cada caractere é um dígito
            {
                return false; // Retorna falso se encontrar um não dígito
            }
        }
        return true; // Retorna verdadeiro se todos os caracteres forem dígitos
    }
}

