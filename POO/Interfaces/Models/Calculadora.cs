using POO.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interface.Models
{
    internal class Calculadora : ICalculadora
    {
        // Após sinal ':', informar a interface 'ICalculadora'
        // e clicar na opção 'implementar interface'
        // assim os métodos existentes na interface
        // agora existem na classe calculadora

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
