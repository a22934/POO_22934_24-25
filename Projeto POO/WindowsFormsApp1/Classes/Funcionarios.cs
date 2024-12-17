using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ClientManagement_OOP
{
    public class Funcionario : Pessoa
    {
        public string NumeroFuncionario { get; set; }
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Funcionario"/>.
        /// </summary>
        /// <param name="nome">Nome do funcionário.</param>
        /// <param name="numeroFuncionario">Número do funcionário.</param>
        /// <param name="password">Password do funcionário.</param>
        public Funcionario(string nome, string numeroFuncionario, string password)
            : base(nome, password)
        {
            NumeroFuncionario = numeroFuncionario;
        }
        /// <summary>
        /// Retorna uma string que representa o Funcionário.
        /// </summary>
        /// <returns>Uma string que representa o Funcionário.</returns>
        public override string ToString()
        {
            return $"{base.ToString()}, ID: {NumeroFuncionario}";
        }
    }
}