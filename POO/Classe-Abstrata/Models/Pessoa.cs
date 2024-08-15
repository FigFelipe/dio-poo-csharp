using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classe_Abstrata.Models
{
    internal class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        // Construtor
        public Pessoa(string nome)
        {
            Nome = nome;
        }

    }
}
