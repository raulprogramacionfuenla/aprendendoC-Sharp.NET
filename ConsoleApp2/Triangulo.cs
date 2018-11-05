using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacaoTriangulo
{
    class Triangulo
    {
        public double a, b, c;

        public double calculaArea ()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
