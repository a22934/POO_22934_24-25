using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ClientManagement_OOP
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string NumeroFuncionario { get; set; }
        public string Password { get; set; }

        public Funcionario(string nome, string numeroFuncionario, string password)
        {
            Nome = nome;
            NumeroFuncionario = numeroFuncionario;
            Password = password;
        }
        public override string ToString()
        {
            return $"Name: {Nome}, ID: {NumeroFuncionario}";
        }
    }
}