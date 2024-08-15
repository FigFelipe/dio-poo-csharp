using POO.Classe_Abstrata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classe_Abstrata
{
    internal class ClasseAbstrata
    {
        /* Classe Abstrata
         * 
         * O que é:
         * - Um modelo de classe (molde) para ser obrigatóriamente herdado, 
         *   não podendo ser instanciada.
         * 
         */

        public static void ExemploClasseAbstrata()
        {
            Corrente c = new Corrente();

            c.Creditar(500);
            c.ExibirSaldo();
            
        }
    }
}
