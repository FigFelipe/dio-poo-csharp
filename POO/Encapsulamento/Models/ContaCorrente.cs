using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Encapsulamento.Models
{
    internal class ContaCorrente
    {
        // Atributos
        public int Numero { get; set; }
        private decimal Saldo { get; set; }

        // Construtor
        public ContaCorrente(int numero, decimal saldoInicial)
        {
            Numero = numero;
            Saldo = saldoInicial;
        }

        // Metodos
        public void Sacar(decimal valor)
        {
            if(valor <= Saldo)
            {
                Saldo -= valor;

                Console.WriteLine($"Foi realizado o saque no valor de R${valor.ToString("F2")}.");
                Console.WriteLine($"Seu saldo atual é de: R${Saldo.ToString("F2")}.");
            }
            else
            {
                Console.WriteLine("Saque não realizado. O saldo é insuficiente.");
            }
        }
    }
}
