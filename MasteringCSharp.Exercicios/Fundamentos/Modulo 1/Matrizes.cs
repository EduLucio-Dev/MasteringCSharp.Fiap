using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp.Exercicios.Fundamentos.Modulo_1
{
    internal class Matrizes
    {        
        public static void ManipulandoMatrizes()
        {
            int[,] matriz = { { 1, 2, }, { 3, 4 }, { 5, 6 } };

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine($"{linha},{coluna} => {matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

        }

        public static void SomarMatrizes()
        {
            int[,] matriz = { { 1, 2, }, { 3, 4 }, { 5, 6 } };
            int soma = 0;

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    soma = soma + matriz[linha, coluna];
                    Console.WriteLine($"{linha},{coluna} => {matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(soma);


        }

        public static void TrocarMatrizesParesPorZero()
        {
            int[,] matriz = { { 45, 12, }, { 22, 4 }, { 5, 6 } };
            int divisaoMatrizes = 0;

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    divisaoMatrizes = matriz[linha,coluna] % 2;
                    if (divisaoMatrizes == 1)
                    {
                        matriz[linha,coluna] = 1;
                    }
                    else
                    {
                        matriz[linha, coluna] = 0;
                    }
                    Console.WriteLine($"{linha},{coluna} => {matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
