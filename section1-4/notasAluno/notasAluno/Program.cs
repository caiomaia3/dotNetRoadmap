using System;

namespace notasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasAluno aluno;
            aluno = new NotasAluno();
            double NOTA_MEDIA = 60;

            Console.Write("Nome do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas:(Uma em cada linha)");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTA FINAL:{0}",aluno.CalcularNotaFinal());
            bool ehAprovado = aluno.CalcularNotaFinal() >= NOTA_MEDIA;
            if (ehAprovado)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO.");
                Console.WriteLine("FALTARAM {0} PONTOS.",NOTA_MEDIA-aluno.CalcularNotaFinal());
            }
        }
    }
}
