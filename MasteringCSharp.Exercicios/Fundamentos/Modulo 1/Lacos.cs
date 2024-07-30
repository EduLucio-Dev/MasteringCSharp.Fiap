namespace MasteringCSharp.Exercicios
{   public class Lacos
    {
        /* Estudos de laços de repetição */

        #region Laços
        public static void LacoDo()
        {
            double nota1, nota2;
            double mediaTurma, mediaNotas;
            int contagemAluno;

            nota1 = 0;
            nota2 = 0;
            contagemAluno = 0;
            mediaTurma = 0;
            mediaNotas = 0;
            do
            {
                Console.WriteLine("Digite a nota 1");
                nota1 = Convert.ToDouble(Console.ReadLine());
                if (nota1 != -1)
                {
                    Console.WriteLine("Digite a nota 2");
                    nota2 = Convert.ToDouble(Console.ReadLine());

                    mediaNotas = (nota1 + nota2) / 2;

                    Console.WriteLine($"Media: {mediaNotas}");
                    mediaTurma = mediaNotas;
                }

                contagemAluno++;

            } while (nota1 != -1);

            mediaTurma = mediaNotas / contagemAluno;
            Console.WriteLine($"A media da turma é {mediaTurma}");
        }

        #endregion
    }
}
