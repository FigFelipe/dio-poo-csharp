using POO.Heranca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heranca
{
    internal class Heranca
    {
        /* Pilar POO
         * 3. Heranca
         * 
         *  - Permite reutilizar atributos, métodos,
         *  e comportamentos de uma classe em outras classes.
         *  
         *  - Agrupa objetos do mesmo tipo, porém com
         *  características diferentes.
         */
         
        public static void ExemploHeranca()
        {
            // Instanciando um novo objeto do tipo 'Aluno'
            // o objeto é herdado do objeto 'Pessoa'
            Aluno aluno = new Aluno();

            // Instanciando um novo objeto tipo 'Professor'
            Professor professor = new Professor();

            // Atributos herdados da classe 'Pessoa'
            aluno.Nome = "Felipe";
            aluno.Idade = 99;

            professor.Nome = "DIO Lucas";
            professor.Idade = 20;

            // Atributo não herdados
            aluno.Nota = 10;
            professor.Salario = 1000m;

            // Método herdado da classe 'Pessoa'
            aluno.Apresentar();

        }
    }
}
