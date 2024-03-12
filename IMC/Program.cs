using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu peso em KG:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua altura em Metros:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);



            if (imc < 16.9)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau 1");
            }
            else if (imc >= 35 && imc <= 40)
            {
                Console.WriteLine("Obesidade Grau 2");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade Grau 3");
            }



            Console.ReadKey();
        }
    }
}

