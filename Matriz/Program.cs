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
        }
        

        static void Main(string[] args)
        {
            int numLinha, numCol;
            Console.WriteLine("Digte o número de linhas da matriz");
            numLinha = int.Parse(Console.ReadLine());
            Console.WriteLine("Digte o número de colunas da matriz");
            numCol = int.Parse(Console.ReadLine());
            int[,] mat = new int[numLinha, numCol];

            // Preenchimento da matriz

            for (int i = 0; i < numLinha; i++)
                for (int j = 0; j < numCol; j++)
                {

                    {
                        mat[i, j] = int.Parse(Console.ReadLine());
                    }
                }

            for (int i = 0; i < numLinha; i++)
                for (int j = 0; j < numCol; j++)
                {
                    {
                        Console.Write(mat[i, j] + "\t");

                    }
                    
                    
                    Console.WriteLine();
                              
                }
            int lin, col;
            Console.WriteLine("Digite a linha do elemento a ser buscado");
            lin = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coluna do elemento a ser buscado");
            col = int.Parse(Console.ReadLine());

            if (lin >= numLinha || col >= numCol)
            {
                Console.WriteLine("Fora do intervalo!");
            }
            else
            {
                imprimeVizinhos(mat, lin, col, numLinha, numCol);
            }
            

            Console.ReadLine();
        }

       
        
    }
}
