using POO.Encapsulamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Encapsulamento
{
    internal class Encapsulamento
    {
        /* Pilar - POO:
         * 2. Encapsulamento
         * 
         * - Protege a classe e define limites para alterações
         * de suas respectivas propriedades
         * 
         * - Oculta seu comportamento e expõe somente o necessário
         */

        public static void ExemploEncapsulamento()
        {
            // Criando um novo objeto tipo 'ContaCorrente'
            // e instanciado com o 'numeroConta' e 'saldoInicial'
            ContaCorrente contaCorrente = new ContaCorrente(1, 1000);

            contaCorrente.Sacar(100);
        }
    }
}
