using System;


namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa para realização do curso C# COMPLETO 2018  Section 2, Le 12
           
            // Treinando Tipos de Dados 

            String nome;
            int idade;
            double altura;
            char sexo;
            
            //Realizando a leitura quando existe quebra de linha
            //Console.WriteLine("Digite o nome: ");
            //nome = Console.ReadLine();

            //Console.WriteLine("Digite a idade: ");
            //idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a altura");
            //altura = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o sexo");
            //sexo = char.Parse(Console.ReadLine());

            //Realizando a leitura apenas por espaço

            //A função Split separa a String lida de acordo com o caracter;

          
            string[] vet = Console.ReadLine().Split(' ');

            nome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2]);
            sexo = char.Parse(vet[3]);

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Sexo" + sexo);

            Console.ReadLine();

            
        }
    }
}
