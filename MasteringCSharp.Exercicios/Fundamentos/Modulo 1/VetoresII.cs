using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MasteringCSharp.Exercicios.Fundamentos.Modulo_1
{
    internal class VetoresII
    {
        static void ExibeVetor(string[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"{i} => {v}");
            }
        }
        public static void InverterVetor()
        {
            string[] cores = { "Preto", "Branco", "Vermelho", "Azul", "Amarelo" };
            
            Console.WriteLine("Invertendo os vetores");
            Array.Reverse(cores); //Reverte a posição dos vetores
            ExibeVetor(cores);

            Console.WriteLine("Reodernando os vetores");
            Array.Sort(cores); // por ordem alfabetica
            ExibeVetor(cores);

            Console.WriteLine("Busca Vetor");
            string corEscolhida;
            Console.Write("Digite uma cor");
            corEscolhida = Console.ReadLine();

            //Array.BynarySearch(array,entrada) procura e retorna o indice
            //se tiver em ordem alfabetica. 
            int indice = Array.BinarySearch(cores, corEscolhida);

            //Array.IndexOf(array,entrada) procura de forma desordenada.
            int indice2 = Array.IndexOf(cores, corEscolhida);

            if (indice2 >= 0)
            {
                Console.WriteLine($"A cor '{corEscolhida}' esta no indice: {indice2}");
            }
            else
            {
                Console.WriteLine("Cor não encontrada");
            }
        }

    }
}
