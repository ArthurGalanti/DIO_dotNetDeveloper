using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_dotNetDeveloper.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa() // Método construtor
        {
            Nome = "";
            Idade = 30;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome},e tenho {Idade} anos");
        }
    }
}