using System;

namespace ClientManagement_OOP
{
    public class Client : Pessoa
    {
        public string NIF { get; set; }
        public string Contact { get; set; }

        public Client(string nome, string nif, string contact, string password)
            : base(nome, password)
        {
            NIF = nif;
            Contact = contact;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, NIF: {NIF}, Contact: {Contact}";
        }
    }
}
