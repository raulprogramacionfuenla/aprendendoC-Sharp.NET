using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cadastro de Conta");
            Console.WriteLine("Informe o nome do titular");
            String titular = Console.ReadLine();
            Console.WriteLine("Haverá saldo inicial? S/N");
            char saldoInicial = char.Parse(Console.ReadLine());
           

            if (saldoInicial == 'S' || saldoInicial == 's')
            {
                Console.WriteLine("Informe o saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
            }
            else if (saldoInicial == 'N' || saldoInicial == 'n')
            {
                
            }

            else
            {
                Console.WriteLine("Informação inválida, responda com S para Sim ou N para Não ");
            }


        }
    }
}
