using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBanco
{
    class Program
    {
        // Este programa tem o objeito de realizar operações de saque, depoisito e saldo para uma conta bancaria para treinar questões de orientação objeto: Instanciação de classe, sobrecarga de métodos e construtores
        static void Main(string[] args)
        {
            // leitura do dados do titular
            Console.WriteLine("Cadastro de Conta");
            Console.WriteLine("Informe o nome do titular");
            String titular = Console.ReadLine();
            Console.WriteLine("Haverá saldo inicial? S/N");
            char saldoInicial = char.Parse(Console.ReadLine());

            // criacao do objetio conta
            ContaBancaria conta;

            // caso o usuario opte pelo deposito inicial de saldo deverá informar o saldo
            if (saldoInicial == 'S')
            {
                Console.WriteLine("Informe o saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(titular, saldo);
            }
            // caso não pode pelo depoisito inicial o objeto devera ser construido sem passar o saldo
            else 
            {
                conta = new ContaBancaria(titular);
            }

            
            // Exibe os dados da conta criada
            Console.WriteLine("\n Dados da conta criada: ");
            Console.WriteLine(conta.ToString());
            Console.WriteLine("\n");

            // usuario informa a opção desejada
            int op;
            Console.WriteLine("Digite a opção desejada: \n" +
                "1 - Deposito \n"  +
                "2 - Saque \n" +
                "3- Saldo \n" +
                "4 - Informações da conta\n");

            op = int.Parse(Console.ReadLine());

            while (op != 0)
            {
                // operacao de depoisito
                if (op == 1)
                {
                    double valorDeposito;
                    Console.WriteLine("Digite o valor do Depósito: ");
                    valorDeposito = double.Parse(Console.ReadLine());
                    conta.depositarSaldo(valorDeposito);
                    Console.WriteLine(conta.ToString());
                }
                // operacao de saque
                else if (op == 2)
                {
               
                    double valorSaque;
                    Console.WriteLine("Digite o valor do saque\n");
                    valorSaque = double.Parse(Console.ReadLine());
                    conta.saqueSaldo(valorSaque);
                    Console.WriteLine(conta.ToString());
                }
                // visaulizar saldo
               else if (op == 3)
                {
                    Console.WriteLine("Saldo Atual: " + conta.saldo);
                    
                }
                // visualizar todos os dados da conta 
                else if (op == 4)
                {
                    Console.WriteLine(conta.ToString());
                }
                else
                {
                    Console.WriteLine("\n Opção Inválida \n");
                }

                // usuario deverá informar novamente as opções 
                Console.WriteLine("Digite a opção desejada: \n" +
                "1 - Deposito \n" +
                "2 - Saque \n" +
                "3- Saldo \n" +
                "4 - Informações da conta\n" +
                "0 - Sair ");
                op = int.Parse(Console.ReadLine());
            }

        }

            
    }
}
