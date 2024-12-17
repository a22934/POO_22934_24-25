using System;

namespace ClientManagement_OOP
{
    public class Client : Pessoa
    {
        public string NIF { get; set; }
        public string Contact { get; set; }
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Client"/>.
        /// </summary>
        /// <param name="nome">Nome do cliente</param>
        /// <param name="nif">Nif do cliente</param>
        /// <param name="contact">Contacto do cliente</param>
        /// <param name="password">Password do cliente</param>
        public Client(string nome, string nif, string contact, string password)
            : base(nome, password)
        {
            NIF = nif;
            Contact = contact;
        }
        /// <summary>
        /// Retorna uma string que representa o cliente.
        /// </summary>
        /// <returns>Uma string que representa o cliente.</returns>
        public override string ToString()
        {
            return $"{base.ToString()}, NIF: {NIF}, Contact: {Contact}";
        }
    }
}
