using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa simples para calcula da media

           const int tam =3;
           double[] vet = new double[tam];
           for (int i=0; i<vet.Length; i++)

            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            

            double soma=0;

            for (int i=0; i<vet.Length; i++)
            {
                soma = soma + vet[i];
            }
            double media = soma / vet.Length;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine(); 

        }
    }
}
