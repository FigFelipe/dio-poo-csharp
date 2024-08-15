using POO.Interface.Interfaces;
using POO.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interface
{
    internal class InterfacesExemplo
    {
        /* Interface
         * 
         * O que é:
         * 
         * - Contrato que pode ser implementado por uma classe, ou seja,
         * todas as classes implementadas, devem possuir o mesmo metodo da classe de contrato
         * 
         * - Ao contrario da herança, a classe implementada pode
         * possuir multiplas interfaces
         * 
         * - Similar a classe abstrata, e não pode ser instanciada
         * 
         */

        public static void ExemploInterface()
        {
            // Instanciando um objeto tipo interface 'Calculadora'
            ICalculadora calculadora = new Calculadora();

            Console.WriteLine(calculadora.Somar(1, 9));
            Console.WriteLine(calculadora.Subtrair(1, 9));
            Console.WriteLine(calculadora.Dividir(1, 9));
            Console.WriteLine(calculadora.Multiplicar(1, 9));

        }
    }
}
