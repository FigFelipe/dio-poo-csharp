using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Models
{
    internal class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Metodos

        // Virtual --> Indica que o método PODE ser sobrescrito
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, {Idade} anos.");
        }
        
    }
}
