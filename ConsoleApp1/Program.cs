using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static double  somaIdade (int bufferIdade)
        {
            int contador = 0;
            int idade = 0;

            while (bufferIdade >= 0)
            {
                idade = bufferIdade + idade;
                contador++;
                bufferIdade = int.Parse(Console.ReadLine());
               
            }
            double mediaIdade = (double) idade / contador;
            return mediaIdade;
        }

        static void Main(string[] args)
        {
            // Este problema calcula a média das idades informadas pelo usuario
            // O usuoario devera informar as idades e para encerrar informar um número negativo.
            // O número 0 deverá ser aceito

           
            int bufferIdade;
            

            Console.WriteLine("Insira a idade, para sair informe um valor negativo");
            bufferIdade = int.Parse(Console.ReadLine());


            if (bufferIdade < 0)
            {
                Console.WriteLine("INVÁLIDO");
            }
            else
            {
                Console.WriteLine("Média: " + somaIdade(bufferIdade));
            }

            Console.ReadLine();
            
            
        }
    }
}
