using POO.Classe_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classe_Object
{
    internal class ClasseObject
    {
        /* Classe Object
         * 
         * O que é:
         * - É a classe mãe System.Object, de todas as outras classes
         * na hierarquia do .NET
         * 
         * - Todas as classes derivam, direta ou indiretamente, da classe
         * Object.
         * 
         * - A classe Object tem o objetivo de prover serviços de baixo nível
         * para as suas classes filhas
         * 
         */

        public static void ExemploClasseObject()
        {
            // Instanciando um novo objeto do tipo 'computador'
            Computador computador = new Computador();

            // Metodo toString sobrescrito
            Console.WriteLine(computador.ToString());

        }
    }
}
