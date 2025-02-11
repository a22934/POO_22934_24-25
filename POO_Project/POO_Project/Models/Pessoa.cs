namespace Models
{
    /// <summary>
    /// Classe abstrata que representa uma pessoa no sistema.
    /// </summary>
    public abstract class Pessoa
    {
        /// <summary>
        /// Nome da pessoa.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Password de acesso da pessoa.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Construtor da classe Pessoa.
        /// </summary>
        /// <param name="name">Nome da pessoa.</param>
        /// <param name="password">Password de acesso.</param>
        public Pessoa(string name, string password)
        {
            Name = name;
            Password = password;
        }

        /// <summary>
        /// Retorna uma representação textual da pessoa.
        /// </summary>
        /// <returns>Uma string que contem o nome da pessoa.</returns>
        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
