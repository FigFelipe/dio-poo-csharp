using POO.Polimorfismo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    internal class Polimorfismo
    {
        /* POO Pilar
         * 4. Polimorfismo
         * 
         *  - Do grego significa 'muitas formas'
         *  - Sobrescreve métodos das classes filhas para que se comportem de
         *  maneira diferente e ter a sua própria implementação
         *  
         *  Resumo:
         *  
         *  - Sobrescrever método para comportar-se de maneira diferente,
         *  tendo a sua propria implementação.
         *  
         */
        
        public static void ExemploPolimorfismo()
        {
            // Instanciando um novo objeto do tipo 'Aluno'
            Aluno aluno = new Aluno();

            aluno.Nome = "Felipe";
            aluno.Idade = 99;
            aluno.Nota = 10;

            aluno.Apresentar();

            // Instanciando um novo objeto do tipo 'Professor'
            Professor professor = new Professor();

            professor.Nome = "Lucas";
            professor.Idade = 20;
            professor.Salario = 1000m;

            professor.Apresentar();

        }

    }
}
