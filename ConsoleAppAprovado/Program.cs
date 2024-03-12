
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a média do aluno: ");
            int med = int.Parse(Console.ReadLine());

            Console.Write("Qual a porcentagem de presença do aluno: ");
            int presen = int.Parse(Console.ReadLine());

            if (med >= 7 && presen >= 75 || med >= 4 && presen >= 75)
            {
                Console.Write("O aluno está aprovado!");
            }
            else if (med >= 7 && presen < 75 || med >= 4 && presen < 75)
            {
                Console.Write("O aluno está de recuperação");
            }
            else
            {
                Console.Write("O aluno está retido!");
            }
            Console.ReadKey();
        }
    }
}
