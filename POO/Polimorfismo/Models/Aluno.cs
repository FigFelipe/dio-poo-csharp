using POO.Polimorfismo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Models
{
    internal class Aluno : Pessoa
    {
        // Atributos
        public double Nota { get; set; }

        // Metodos
        // Override --> Significa sobrescreve
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, {Idade} anos, sou um aluno nota {Nota}");

        }

    }
}
