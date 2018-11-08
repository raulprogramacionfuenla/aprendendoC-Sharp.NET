using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque
{
    class Produto
    {
        private String nome { get; set; }
        private double valorUnitario { get; set; } 
        private int quantidadeEstoque { get; set; }

        // Controtures sobrecarregados

        // Construtor para quando é informado a quantidade inicial de estoque
        public Produto(string nome, double valorUnitario, int quantidadeEstoque)
        {
            this.nome = nome;
            this.valorUnitario = valorUnitario;
            this.quantidadeEstoque = quantidadeEstoque;
        }

        // Construtor para quando não  é informado a quantidade inicial de estoque
        public Produto(string nome, double valorUnitario)
        {
            this.nome = nome;
            this.valorUnitario = valorUnitario;
            this.quantidadeEstoque = 0;
        }


       
      
        public override string ToString()
        {
            return "Nome: " + nome  + " Valor Unitário: " + valorUnitario + " Unidades em estoque: "  + quantidadeEstoque;
        }

        public void realizarEntrada (int quantidade)
        {
            quantidadeEstoque = quantidadeEstoque + quantidade;
        }

        public void realizarSaida (int quantidade)
        {
            quantidadeEstoque = quantidadeEstoque -  quantidade;
        }
        // Método calculo o valor total de todos estes produtos no estoque
        public double calculaTotalEstoque ()
        {
            return valorUnitario * quantidadeEstoque;
        }

        /*
        public void imprimirDados ()
        {
            Console.WriteLine("Produto: " + nome);
            Console.WriteLine("Valor Unitário: " + valorUnitario);
            Console.WriteLine("Quantidade em estoque: " + quantidadeEstoque);
        }
        */
    }
}
