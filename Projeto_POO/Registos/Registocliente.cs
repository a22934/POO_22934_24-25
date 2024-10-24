using System;
using System.Collections.Generic;

namespace ClientManagement_OOP
{
    public class RegistoCliente
    {
        private List<Client> clientList;

        public RegistoCliente(List<Client> clients)
        {
            clientList = clients; // Recebe a lista de clientes já existente
        }

        // Método para adicionar um novo cliente
        public void AddClient()
        {
            Console.WriteLine("\n--- Add Client ---");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            string nif;
            do
            {
                Console.Write("NIF (Only Numbers): ");
                nif = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nif) || !IsAllDigits(nif)); // Valida a entrada do NIF

            string contact;
            do
            {
                Console.Write("Contacto (Only Numbers): ");
                contact = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(contact) || !IsAllDigits(contact)); // Valida a entrada do Contacto

            // Cria um novo cliente com os dados inseridos
            Client newClient = new Client(name, nif, contact);
            clientList.Add(newClient); // Adiciona o cliente à lista

            Console.WriteLine("Client added successfully!\n");
        }

        // Método para verificar se uma string contém apenas dígitos
        private bool IsAllDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
