using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBanco
{
    class ContaBancaria
    {
        // Atributo numero da conta terá seu atributo set privado pois não poderá ser alterado uma vez instânciado o objeto
        public int numero { get; private set;}
        // Atributo titular poderá ser consultado (get) e alterado (set) a qualquer momento
        public String titular { get; set; }
        // O atributo saldo somente poderá ser consultado alterado (set) por métodos especificos 
        public double saldo { get; private set; }
        
        //Construtores sobrecarregados, pode-se passar o saldo ou não para caso haja saldo inicial ou não
        public ContaBancaria (String titular)
        {
            this.titular = titular;
            this.saldo = 0;
            this.gerarNumeroConta();
        }
        
        public ContaBancaria (String titular, double saldo) 
        
        {
            this.titular = titular;
            this.saldo = saldo;
            numero = this.gerarNumeroConta();

        }

        // Esta funcao gera um numero para conta de forma aleatoria
        public int gerarNumeroConta ()
        {
            Random randNum = new Random();
            return randNum.Next(10000, 99999);
            numero = this.gerarNumeroConta();

        }

        // Funcao para o deposito do saldo
        public void depositarSaldo (double valor)
        {
            this.saldo = this.saldo + valor;
        }

        // Funcao para saque do saldo (são descontados o valor de 5 reais para qualquer valor descontado"
        public void saqueSaldo (double valor)
        {
            this.saldo = this.saldo - valor - 5.00;
        }

        // Metodo toString exibe as informaçoes da conta 
        public override string ToString()
        {
            return "Dados da conta: Conta - Número: " + this.numero + " Titular: " + titular + " Saldo: " + saldo; 
        }
    }
}
