using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            double preco;
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o preço");
            preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            Console.WriteLine("Digite a opção: " +
                  "\n 1 - Entrada de Estoque" +
                  "\n 2 - Saída de Estoque" +
                  "\n 3 - Visualizar Dados" +
                  "\n 4- Visualizar quantidade total no estoque" +
                  "\n 0 - Finalizar");

            int op =  int.Parse(Console.ReadLine());
           
            while (op != 0) { 
                if (op==1)
                {
                    int quantidade;
                    Console.WriteLine("Digite a quantidade de entrada: ");
                    quantidade = int.Parse(Console.ReadLine());
                    p.realizarEntrada(quantidade);
                    p.imprimirDados();
                }

                else if (op == 2)
                {
                    int quantidade;
                    Console.WriteLine("Digite a quantidade de saída: ");
                    quantidade = int.Parse(Console.ReadLine());
                    p.realizarSaida(quantidade);
                    p.imprimirDados();
                }

                else if (op == 3)
                {
                    p.imprimirDados();
                }

                else if (op == 4 )
                {
                    Console.WriteLine("Valor total do produto no estoque: " + p.calculaTotalEstoque());
                }
                
                    Console.WriteLine("Digite a opção: " +
                  "\n 1 - Entrada de Estoque" +
                  "\n 2 - Saída de Estoque" +
                  "\n 3 - Visualizar Dados" +
                  "\n 4- Visualizar quantidade total no estoque" +
                  "\n 0 - Finalizar");
                op = int.Parse(Console.ReadLine());
            }
                
            Console.WriteLine("Fim da execução");
            Console.ReadLine();

        }



    }
}
