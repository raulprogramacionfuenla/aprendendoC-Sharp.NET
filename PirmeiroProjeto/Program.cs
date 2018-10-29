using System;


namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa para realização do curso Section 2, Lession  12
           
            // Treinando Tipos de Dados 

            String nome;
            int idade;
            double altura;
            char sexo;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura");
            altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(sexo);

            Console.ReadLine();

            
        }
    }
}
