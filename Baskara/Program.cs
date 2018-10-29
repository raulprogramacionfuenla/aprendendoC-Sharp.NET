using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa se propoe a resolver uma equacao de segundo grau, recebendo os coeficientes a, b e c da 
            // equacao e imprimir as duas raizes 
            // Programa para realização do curso C# COMPLETO 2018  Section 2, Lecture  13

            double a ;
            double b ;
            double c ;
            double delta;
            double raiz1;
            double raiz2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine("Não possui raizes");
            }
            else if (delta == 0) {
                raiz1 = (-b + delta) /( 2 * a * c);
                Console.WriteLine("Raiz1: " + raiz1);
            }
            else
            {
                raiz1 = (-b - Math.Sqrt(delta)) / (2 * a );
                raiz2 = (-b + Math.Sqrt(delta)) / (2 * a );
                Console.WriteLine("Raiz1: " + raiz1);
                Console.WriteLine("Raiz2: " + raiz2);
            }
            Console.ReadLine();
        }
    }
}
