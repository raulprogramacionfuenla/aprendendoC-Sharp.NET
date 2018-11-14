using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {

       static void imprimeVizinhos(int[,] mat, int lin, int col, int numLinhas, int numColunas)
        {
            // impressao do vizinho de cima 
            if (lin > 0)
            {
                Console.WriteLine("Vizinho de cima: " + mat[lin - 1, col]);
            }
            else
            {
                Console.WriteLine("Vizinho de cima: X ");
            }

            // impresao do vizinho de baixo

            if (lin < numLinhas - 1)
            {
                Console.WriteLine("Vizinho de baixo: " + mat[lin + 1, col]);
            }
            else
            {
                Console.WriteLine("Vizinho de baixo: X ");
            }
            // impresao vizinho da esquerda

            if (col > 0)
            {
                Console.WriteLine("Vizinho da esquerda: " + mat[lin, col - 1]);
            }

            else
            {
                Console.WriteLine("Vizinho da esquerda: X ");
            }

            // impressao vizinho da direita

            if (col < numColunas -1)
            {
                Console.WriteLine("Vizinho da direita: " + mat[lin, col + 1]);
            }

            else
            {
                Console.WriteLine("Vizinho da direita: X ");
            }
        }
        

        static void Main(string[] args)
        {
            int numLinhas, numColunas;
            Console.WriteLine("Digte o número de linhas da matriz");
            numLinhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digte o número de colunas da matriz");
            numColunas = int.Parse(Console.ReadLine());

            Matriz matriz = new Matriz(numLinhas, numColunas);
            matriz.preencherMatriz();
           
            int lin, col;
            Console.WriteLine("Digite a linha do elemento a ser buscado");
            lin = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coluna do elemento a ser buscado");
            col = int.Parse(Console.ReadLine());

            matriz.buscarNumero(lin, col);
            matriz.imprimirVizinhoSuperior(lin, col);
            matriz.imprimirVizinhoInferior(lin, col);
            matriz.imprimirVizinhoEsquerda(lin, col);
            matriz.imprimirVizinhoDireita(lin, col);

            Console.ReadLine();
        }

       
        
    }
}
