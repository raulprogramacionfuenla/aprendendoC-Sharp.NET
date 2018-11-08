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
        

        public Produto(string nome, double valorUnitario)
        {
            this.nome = nome;
            this.valorUnitario = valorUnitario;
            this.quantidadeEstoque = 0;
        }

        public override string ToString()
        {
            return nome  + "|||" + valorUnitario + "|||"  + quantidadeEstoque;
        }

        public void realizarEntrada (int quantidade)
        {
            quantidadeEstoque = quantidadeEstoque + quantidade;
        }

        public void realizarSaida (int quantidade)
        {
            quantidadeEstoque = quantidadeEstoque -  quantidade;
        }

        public double calculaTotalEstoque ()
        {
            return valorUnitario * quantidadeEstoque;
        }


        public void imprimirDados ()
        {
            Console.WriteLine("Produto: " + nome);
            Console.WriteLine("Valor Unitário: " + valorUnitario);
            Console.WriteLine("Quantidade em estoque: " + quantidadeEstoque);
        }
    }
}
