using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp.Exercicios.Fundamentos.Modulo_1
{
    internal class Procedimentos
    {
        //Procedimento não vão em classes, porem 

        static void Saudacao(string usuario, int hora)
        {
            string msg;

            if (hora <= 12)
            {
                msg = "Bom dia!";
            }
            else if (hora < 18)
            {
                msg = "Boa tarde!";
            }
            else
            {
                msg = "Boa noite";
            }

        }



        public static void Multiplos10(int valorMultiplicar)
        {
            int calculo = 0;
            for (int i = 1; i < valorMultiplicar; i++)
            {
                calculo = valorMultiplicar * i;
                Console.WriteLine(calculo);
            }

        }

        public static void ExibirOrdem(int valor1, int valor2)
        {
            int maior, menor;

            if (valor1 < valor2)
            {
                menor = valor1;
                maior = valor2;
            }
            else
            {
                menor = valor2;
                maior = valor1;
            }

            for (int i = menor; i <= maior; i++)
            {
                Console.WriteLine(i);
            }
        }


    }
}
