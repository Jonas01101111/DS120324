using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a média do aluno:");
                int media = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a presença do aluno:");
                int presenca = int.Parse(Console.ReadLine());

            if (media >= 7 && presenca >=75)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media < 4 && presenca < 75)
            {
                Console.WriteLine("Retido");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
           
            Console.ReadKey();
        }
    }
}
