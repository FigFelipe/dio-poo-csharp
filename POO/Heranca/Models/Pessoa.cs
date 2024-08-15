using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heranca.Models
{
    internal class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Metodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, {Idade} anos.");
        }
        
    }
}
