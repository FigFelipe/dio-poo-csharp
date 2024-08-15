using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classe_Abstrata.Models
{
    internal class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;

            Console.WriteLine($"O valor R${valor.ToString("F2")} foi depositado em sua conta.");
        }
    }
}
