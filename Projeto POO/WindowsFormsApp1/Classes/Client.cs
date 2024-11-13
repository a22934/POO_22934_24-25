using System;

namespace ClientManagement_OOP
{
    public class Client
    {
        public string Name { get; set; }
        public string NIF { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }

        // Construtor para inicializar um cliente
        public Client(string name, string nif, string contact, string password)
        {
            Name = name;
            NIF = nif;
            Contact = contact;
            Password = password;
        }

        public override string ToString()
        {
            return $"Name: {Name}, NIF: {NIF}, Contact: {Contact}";
        }
    }
}
