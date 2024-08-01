using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp.Exercicios.Fundamentos.Modulo_1
{
    internal class Funcao
    {
        public int Fatorial(int valor)
        {

            int fat = 1;
            for (int i = valor; i > 1; i--)
            {

                fat *= i;

            }
            return fat;
        }

    }
}
