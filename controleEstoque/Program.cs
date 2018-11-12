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
            int numProdutos;
            String nome;
            double preco;
            Produto[] produtos;

            Console.WriteLine("Digite o número de produtos que deseja cadastrar");
            numProdutos = int.Parse(Console.ReadLine());
            produtos = new Produto[numProdutos];

            for (int i=0; i < produtos.Length; i++)
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o preço");
                preco = double.Parse(Console.ReadLine());
                produtos[i] = new Produto(nome, preco);
            }

            //criacao do objeto
            
            
           // Console.WriteLine("Teste do to String");
          //  Console.WriteLine(p.ToString());


            Console.WriteLine("Digite a opção: " +
                  "\n 1 - Entrada de Estoque" +
                  "\n 2 - Saída de Estoque" +
                  "\n 3 - Visualizar Dados" +
                  "\n 4- Visualizar valor quantidade total no estoque" +
                  "\n 5 - Lista de todos os Produtos  " + 
                  "\n 0 - Finalizar");

            int op =  int.Parse(Console.ReadLine());
           
            // caso não digite 0 o fluxo do programa continua, caso digite 0 o programa é encerrado

            
            while (op != 0) { 
            // caso digite 1 entra no cadastro de entrada de estoque
                if (op==1)
                {
                    int quantidade;
                    int posicaoVetor;
                    Console.WriteLine("Digite a posicao do vetor do produto");
                    posicaoVetor = int.Parse(Console.ReadLine());

                    if (posicaoVetor >= 0 && posicaoVetor < produtos.Length)

                    {
                        Console.WriteLine("Digite a quantidade de entrada: ");
                        quantidade = int.Parse(Console.ReadLine());
                        produtos[posicaoVetor].realizarEntrada(quantidade);
                        Console.WriteLine(posicaoVetor.ToString());

                    }

                    else
                    {
                        Console.WriteLine("Valor fora do limite! \n");
                    }

                }
                // caso digite 1 entra no cadastro de saída de estoque

                else if (op == 2)
                {
                    int quantidade;
                    int posicaoVetor;
                    Console.WriteLine("Digite a posicao do vetor do produto");
                    posicaoVetor = int.Parse(Console.ReadLine());
                    if (posicaoVetor >= 0 && posicaoVetor < produtos.Length)

                    {
                        Console.WriteLine("Digite a quantidade de saída: ");
                        quantidade = int.Parse(Console.ReadLine());
                        produtos[posicaoVetor].realizarSaida(quantidade);
                        Console.WriteLine(produtos[posicaoVetor].ToString());

                    }

                    else
                    {
                        Console.WriteLine("Valor fora do limite! \n");
                    }
                    
                }
                // caso digite 3 apenas visualiza os dados do produto

                else if (op == 3)
                {
                    int posicaoVetor;
                    Console.WriteLine("Digite a posicao do vetor do produto");
                    posicaoVetor = int.Parse(Console.ReadLine());
                                        Console.WriteLine(produtos[posicaoVetor].ToString());
                    if (posicaoVetor >= 0 && posicaoVetor < produtos.Length)

                    {
                        Console.WriteLine(produtos[posicaoVetor].ToString());

                    }

                    else
                    {
                        Console.WriteLine("Valor fora do limite! \n");
                    }

                }

                // caso digite 4 realiza o calculo de todo valor daquele produto no estoque

                else if (op == 4 )
                {
                    int posicaoVetor;
                    Console.WriteLine("Digite a posicao do vetor do produto");
                    posicaoVetor = int.Parse(Console.ReadLine());
                    if (posicaoVetor >= 0 && posicaoVetor < produtos.Length)
                    {
                        Console.WriteLine("Valor total do produto no estoque: " + produtos[posicaoVetor].calculaTotalEstoque() + "\n");

                    }

                    else
                    {
                        Console.WriteLine("Valor fora do limite! \n");
                    }
                }

                else if (op == 5)
                {
                    for (int i=0; i<produtos.Length; i++)
                    {

                        Console.WriteLine(produtos[i] + "\n");
                    }
                }
         
                
                    Console.WriteLine("Digite a opção: " +
                  "\n 1 - Entrada de Estoque" +
                  "\n 2 - Saída de Estoque" +
                  "\n 3 - Visualizar Dados" +
                  "\n 4 - Visualizar quantidade total no estoque" +
                  "\n 5 - Lista de todos os Produtos  " +
                  "\n 0 - Finalizar \n");
                op = int.Parse(Console.ReadLine());
            }
                
            Console.WriteLine("Fim da execução");
            Console.ReadLine();

        }



    }
}
