using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classe_Abstrata.Models
{
    // Classe abstrata
    // - Serve somente de modelo para ser herdada
    // - Nao pode ser instanciada
    internal abstract class Conta
    {
        // Atributos
        // Protected --> protegido de alterações externas, exceto das classes filhas
        protected decimal saldo;


        // Metodos
        // O metodo abstrato não possui uma implementação
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo.ToString("F2")}");
        }
    }
}
