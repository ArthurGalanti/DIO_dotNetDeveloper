using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetDeveloper.Common.models
{
    /// <summary>
    /// Representa um pessoa física.
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Método construtor
        public Pessoa()
        {
            Nome = "";
            Idade = 30;
        }

        /// <summary>
        /// É um método que recebe o curso da pessoa por parâmetro.
        /// </summary>
        /// <param name="curso">Curso que pessoa estuda.</param>
        /// <returns>Retorna uma string com a apresentação da pessoa.</returns>
        public string Apresentar(string curso)
        {
            string apresentacao = ($"Olá, meu nome é {Nome} e tenho {Idade} anos. Sou estudante de {curso}");
            return apresentacao;
        }
    }
}