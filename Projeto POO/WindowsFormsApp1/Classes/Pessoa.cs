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

        public Pessoa(string nome, string password)
        {
            Nome = nome;
            Password = password;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}";
        }
    }
}
