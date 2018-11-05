using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calculoTriangulo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Console.WriteLine(x.calculaArea());
            Console.WriteLine(y.calculaArea());

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
                Console.WriteLine ("O triangulo Y é maior que o Y");
            }

        }
    }
}
