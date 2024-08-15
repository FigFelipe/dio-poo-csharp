using POO.Abstracao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstracao
{
    internal class Abstracao
    {
        /* Pilar POO 1. Abstração
         * 
         * Abtrair um objeto do mundo real para um contexto específico,
         * considerando apenas os atributos importantes
         * 
         */

        public static void ExemploAbstracao()
        {
            // Criando um novo objeto do tipo 'Pessoa'
            Pessoa p1 = new Pessoa();

            p1.Nome = "Felipe";
            p1.Idade = 99;

            p1.Apresentar();
        }
        
    }
}
