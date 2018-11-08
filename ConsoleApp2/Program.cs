
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacaoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este programa tem o objetivo de calcular a área de 2 triangulos atravez das medidas de seus lados,
            // utilizando a formula de heron

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Console.WriteLine("Triangulo X: " + x.calculaArea());
            Console.WriteLine("Trinagulo Y: " + y.calculaArea());

            if (x.calculaArea() == y.calculaArea())
            {
                Console.WriteLine("Triangulos Iguais");
            }
            else if (x.calculaArea() > y.calculaArea())
            {
                Console.WriteLine("O triagulo X é meior que o Y");
            }
            else
            {
                Console.WriteLine("O triangulo Y é maior que o X");
            }

            Console.ReadLine();

        }
    }
    }

