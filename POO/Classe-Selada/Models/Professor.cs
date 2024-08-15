using POO.Classe_Selada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classe_Selada.Models
{
    // Sealed --> É a instancia final de uma herança,
    // não permite ter classes filhas
    internal class Professor : Pessoa
    {
        // Atributos
        public decimal Salario { get; set; }

        // Métodos
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, {Idade} anos, sou professor, recebo o salario de {Salario} reais.");
        }

    }
}
