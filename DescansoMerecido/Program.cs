using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescansoMerecido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu tempo de contribuição:");
            int trabalho= int.Parse(Console.ReadLine());

            

            if ((idade >= 65) || (trabalho >= 30) ||(idade >= 60 && trabalho >= 25))
            { 
                Console.WriteLine("Seu descanso é merecido");
            }
            else 
            {
                int faltai = 60 - idade;
                int faltat = 25 - trabalho;
                Console.WriteLine("Sua hora não chegou, te faltam "+ faltai + " anos de vida e " + faltat + " anos de trabalho para o descanso merecido");
            }

            Console.ReadKey();
        }
    }
}
