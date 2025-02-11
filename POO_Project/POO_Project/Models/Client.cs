namespace Models
{
    /// <summary>
    /// Representa um cliente no sistema.
    /// </summary>
    public class Client : Pessoa
    {
        /// <summary>
        /// Número de Identificação Fiscal (NIF) do cliente.
        /// </summary>
        public string NIF { get; set; }

        /// <summary>
        /// Contacto do cliente.
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// Construtor da classe Client.
        /// </summary>
        /// <param name="name">Nome do cliente.</param>
        /// <param name="nif">Número de Identificação Fiscal (NIF).</param>
        /// <param name="contact">Contacto do cliente</param>
        /// <param name="password">Password do cliente.</param>
        public Client(string name, string nif, string contact, string password)
            : base(name, password)
        {
            NIF = nif;
            Contact = contact;
        }

        /// <summary>
        /// Retorna uma representação textual do cliente.
        /// </summary>
        /// <returns>Uma string que contem informações principais do cliente.</returns>
        public override string ToString()
        {
            return $"{base.ToString()}, NIF: {NIF}, Contact: {Contact}";
        }
    }
}
