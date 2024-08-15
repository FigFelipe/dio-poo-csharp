using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interface.Interfaces
{
    internal interface ICalculadora
    {
        // Não é necessário utilizar os acessores 'public'
        // pois a interface, por natureza, ja é publica

        // Metodos que não possuam corpo --> Obrigatório
        // Meotodos que possuam um corpo --> Opcionais
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
