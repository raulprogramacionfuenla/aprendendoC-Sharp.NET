using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Esta aplicacao recebe pares de numeros e no final imprime o resultado destas divisoes.
// A quantidade destes pares de numeros é pre-definida peelo usuario

// Exemplo:

// Entrada:

   
// 6 2
// 8 8
// 2 0

// Saída
// 3
// 1
// Não existe

namespace divisaoPontoFlutante
{

    class Program
    {
        // Esta funcao recebe os dois numeros (num1 e num2) e retorna a divisao deles
        public static double divide ()
        {
            string[] buffer;
            double num1, num2;
            //os dois numeros lidos (num1 e num2) devem estar em apenas uma linha
            // o split armazena cada um separadamente em cada uma posicao do vetor buffer

            buffer = Console.ReadLine().Split(' ');
            num1 = double.Parse(buffer[0]);
            num2 = double.Parse(buffer[1]);

            //valida que se o dividendo é zero, não existindo divisao por zero, retorna -1, que é armazenado no vetor de resultados
            if (num2 == 0)
            {
               return -1;

            }
            //caso não seja retorna o desultado da divisao normalmente 
            else
            {
                return num1 / num2;
            }
        }

        public static void imprimirResultado (double[] resultados, int n)
        {
            for (int i = 0; i < n; i++)
            {   
                // Caso no vetor de resultados tenha gravado -1, é exibido o erro de que foi tentado realizar uma divisao por zero
                if (resultados[i] == -1)
                {
                    Console.WriteLine("Erro! Não existe divisão por zero");
                }
                else
                {
                    // Caso contrario é gravado o resultado
                    Console.WriteLine(resultados[i]);
                }
            }
        }
        
        static void Main(string[] args)
        {
            int n;
            //O usuario devera informar inicialmente quantos pares de numeros ele gostara de operar
            n = int.Parse(Console.ReadLine());
            double[] resultados = new double[n];
            
           
            //O for realiza a divisao de cada par de numero, gravando do vetor de resultados
            for (int i=0; i<n; i++)
            {
                resultados[i] = divide();
               
            }
            //Imprimir o vetor de resultados
            imprimirResultado(resultados, n);
           
            Console.ReadLine();
        }
    }
}
