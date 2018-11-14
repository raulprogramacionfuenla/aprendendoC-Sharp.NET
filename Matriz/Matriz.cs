using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Matriz
    {
        public int numColunas;
        public int numLinhas;
        public int[,] matriz;

        

        public Matriz (int numColunas, int numLinhas)
        {
            this.numColunas = numColunas;
            this.numLinhas = numLinhas;
            this.matriz = new int[numLinhas, numColunas];
        }

        public void preencherMatriz ()
        {
            for (int i = 0; i < numLinhas; i++)
                for (int j = 0; j < numColunas; j++)
                {

                    {
                        matriz[i,j] = int.Parse(Console.ReadLine());
                    }
                }
        }

        public void imprimirMatriz()
        {
            for (int i = 0; i < numLinhas; i++)
                for (int j = 0; j < numColunas; j++)
                {

                    {
                        Console.WriteLine(matriz[i,j]);
                    }
                }
        }

        // Valida se a coordenada passada está dentro do limite da matriz, retornando true em caso positivo e false em caso negativo
        public Boolean validarIntervalo (int lin, int col)
        {
            if (lin < numLinhas && col < numColunas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void buscarNumero (int lin, int col)
        {
            if (validarIntervalo (lin,col) == true)
            {
           
                Console.WriteLine("Número buscado: " + matriz[lin, col] + "\n");
            }
            else
            {
                Console.WriteLine("Fora do intervalo!\n");
                
            }
                
            
        }

        public void imprimirVizinhoSuperior (int lin, int col)
        {
            if (validarIntervalo(lin, col) == true)
            {
                if (lin > 0)
                {
                    Console.WriteLine("Vizinho superior: " +  matriz[lin - 1, col]);
                }
                else
                {
                    Console.WriteLine("Vizinho superior: X" );
                }
            }
            else
            {
                Console.WriteLine("Fora do intervalo!");
            }
        }

        public void imprimirVizinhoInferior(int lin, int col)
        {
            if (validarIntervalo(lin, col) == true)
            {
                if (lin < (numLinhas-1))
                {
                    Console.WriteLine("Vizinho inferior: " + matriz[lin + 1, col]);
                }
                else
                {
                    Console.WriteLine("Vizinho inferior: X");
                }
            }
            else
            {
                Console.WriteLine("Fora do intervalo!");
            }
        }

        public void imprimirVizinhoEsquerda(int lin, int col)
        {
            if (validarIntervalo(lin, col) == true)
            {
                if (col > 0 )
                {
                    Console.WriteLine("Vizinho da esquerda: " + matriz[lin, col -1]);
                }
                else
                {
                    Console.WriteLine("Vizinho da esquerda: X");
                }
            }
            else
            {
                Console.WriteLine("Fora do intervalo!");
            }
        }
        public void imprimirVizinhoDireita(int lin, int col)
        {
            if (validarIntervalo(lin, col) == true)
            {
                if (col < (numColunas - 1))
                {
                    Console.WriteLine("Vizinho da direita: " + matriz[lin, col + 1]);
                }
                else
                {
                    Console.WriteLine("Vizinho da direita: X");
                }
            }
            else
            {
                Console.WriteLine("Fora do intervalo!");
            }
        }

    }
}
