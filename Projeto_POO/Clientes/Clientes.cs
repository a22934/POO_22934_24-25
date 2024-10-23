using System;

namespace ClientManagement_OOP
{
    public class Client
    {
        public string Name { get; set; }
        public string NIF { get; set; }
        public string Contact { get; set; }

        // Constructor to initialize a client
        public Client(string name, string nif, string contact)
        {
            Name = name;
            NIF = nif;
            Contact = contact;
        }

        public override string ToString()
        {
            return $"Name: {Name}, NIF: {NIF}, Contact: {Contact}";
        }
    }
}
