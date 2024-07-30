﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp.Exercicios
{
    internal class Vetores
    {
        /* Estudos de vetores */

        #region Vetores - Exercicio Nivel 1

        static int[] v = { 45, -89, 32, -12, 33 };
        public static void ExibirPrimeiroElementosVetores()
        {
            int[] v = { 45, -89, 32, -12, 33 };
            Console.WriteLine(v[0]);
        }
        public static void ExibirNegativosElementosVetores()
        {
            for (int i = 0; i < v.Length; i++)
            {
                i++;
                if (v[i] < 0)
                {
                    Console.WriteLine(v[i]);
                }
            }
        }
        public static void ExibirSomaElementosVetores()
        {
            int somaVetores;
            somaVetores = 0;

            for (int i = 0; i < v.Length; i++)
            {
                somaVetores = somaVetores + v[i];
            }
            Console.WriteLine(somaVetores);
        }
        public static void ExibirMediaElementosVetores()
        {
            int somaVetores;
            double mediaVetores;
            somaVetores = 0;

            for (int i = 0; i < v.Length; i++)
            {
                somaVetores = somaVetores + v[i];
            }
            mediaVetores = (double)somaVetores / v.Length;
            Console.WriteLine(mediaVetores);
        }
        public static void ExibirImparesElementosVetores()
        {
            int restoDivVetores;

            for (int i = 0; i < v.Length; i++)
            {
                restoDivVetores = v[i] % 2;
                if (restoDivVetores == 1 || restoDivVetores == -1)
                {
                    Console.WriteLine(v[i]);
                }
            }
        }

        #endregion

        #region Vetores - Exercicio Nivel 2

        public static void ExibirPrimeiroEUltimoElementosVetores()
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == v[0] || v[i] == v[4])
                {
                    Console.WriteLine(v[i]);
                }
            }
        }
        public static void ExibirIndicesImparesElementosVetores()
        {
            for (int i = 0; i < v.Length; i++)
            {
                i++;
                Console.WriteLine(v[i]);
            }
        }
        public static void ExibirValorExistenteElementosVetores()
        {
            bool s = false;

            for (int i = 0; i < v.Length; i++)
            {
                s = v[i] == 32;
                if (s == true)
                {
                    Console.WriteLine(v[i]);
                }
            }
        }
        public static void ExibirReordenacaoElementosVetores()
        {
            var reodernacao = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < 0)
                {
                    reodernacao = v[i];
                    Console.WriteLine(reodernacao);
                }

            }
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > 0)
                {
                    reodernacao = v[i];
                    Console.WriteLine(reodernacao);
                }

            }

        }
        #endregion
    }
}
