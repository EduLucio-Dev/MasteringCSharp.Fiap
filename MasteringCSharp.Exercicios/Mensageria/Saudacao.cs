using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringCSharp.Exercicios.Mensageria
{
    internal class Saudacao
    {
        public static void VerificaHoraDoDia()
        {
            string usuario = "Eduardo";
            DateTime hora = DateTime.Now;
            string msg;

            if (hora < DateTime.Parse("12:00")) msg = "Bom dia";
            else if (hora < DateTime.Parse("18:00")) msg = "Boa tarde";
            else msg = "Boa noite";

            Console.WriteLine($"{msg} {usuario}, tenha um ótimo dia!");
            Console.WriteLine($"Bom estudos!");
        }
    }
}
