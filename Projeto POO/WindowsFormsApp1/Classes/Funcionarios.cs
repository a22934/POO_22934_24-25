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

        public Funcionario(string nome, string numeroFuncionario, string password)
            : base(nome, password)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, ID: {NumeroFuncionario}";
        }
    }
}