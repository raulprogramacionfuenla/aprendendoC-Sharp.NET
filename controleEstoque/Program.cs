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
            // Curso C# - Udemy 2018
            // Este programa tem o objetivo de treinar conceitos orientação objeto:
            // encapsulamento, contrutores, sobrecarga de método

            // Este programa permite o usuário criar um objeto produto informando seu nome e preco
            String nome;
            double preco;
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o preço");
            preco = double.Parse(Console.ReadLine());

            //criacao do objeto
            Produto p = new Produto(nome, preco);

           // Console.WriteLine("Teste do to String");
          //  Console.WriteLine(p.ToString());


            Console.WriteLine("Digite a opção: " +
                  "\n 1 - Entrada de Estoque" +
                  "\n 2 - Saída de Estoque" +
                  "\n 3 - Visualizar Dados" +
                  "\n 4- Visualizar quantidade total no estoque" +
                  "\n 0 - Finalizar");

            int op =  int.Parse(Console.ReadLine());
           
            // caso não digite 0 o fluxo do programa continua, caso digite 0 o programa é encerrado

            
            while (op != 0) { 
            // caso digite 1 entra no cadastro de entrada de estoque
                if (op==1)
                {
                    int quantidade;
                    Console.WriteLine("Digite a quantidade de entrada: ");
                    quantidade = int.Parse(Console.ReadLine());
                    p.realizarEntrada(quantidade);
                    Console.WriteLine(p.ToString());
                }
                // caso digite 1 entra no cadastro de saída de estoque

                else if (op == 2)
                {
                    int quantidade;
                    Console.WriteLine("Digite a quantidade de saída: ");
                    quantidade = int.Parse(Console.ReadLine());
                    p.realizarSaida(quantidade);
                    Console.WriteLine(p.ToString());
                }
                // caso digite 3 apenas visualiza os dados do produto

                else if (op == 3)
                {
                    Console.WriteLine(p.ToString());
                }

                // caso digite 4 realiza o calculo de todo valor daquele produto no estoque

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
