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
        
        public ContaBancaria (String titular)
        {
            this.titular = titular;
        }
        
        public ContaBancaria (String titular, double saldo) 
        
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void gerarNumeroConta ()
        {
            Random randNum = new Random();
            numero = randNum.Next(10000, 99999);
        }
    }
}
