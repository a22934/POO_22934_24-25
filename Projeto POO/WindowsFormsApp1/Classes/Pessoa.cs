using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClientManagement_OOP
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Pessoa"/>.
        /// </summary>
        /// <param name="nome">Nome da pessoa.</param>
        /// <param name="password">Password da pessoa.</param>
        public Pessoa(string nome, string password)
        {
            Nome = nome;
            Password = password;
        }
        /// <summary>
        /// Retorna uma string que representa a pessoa.
        /// </summary>
        /// <returns>Uma string que representa a pessoa.</returns>
        public override string ToString()
        {
            return $"Nome: {Nome}";
        }
    }
}
