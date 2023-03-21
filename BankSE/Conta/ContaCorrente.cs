using BankSE.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSE.Conta
{
    public class ContaCorrente
    {
        public static int TotalContas { get; private set; }
        public static float TaxaOperacao { get; private set; }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; } 
            private set {
                if(value> 0) { this.numeroAgencia = value; }
            }
        }

        public string Conta { get; set; }

        private double saldo;        //o campo saldo não pode ser público

        public Cliente Titular { get; set; }


        public void Depositar(double valor)
        {
            saldo += valor;
        }


        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("Valor sacado: " + valor);
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }

        }


        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor <= saldo)
            {
                Sacar(valor);
                destino.Depositar(valor);
                //.WriteLine($"{titular} realizou uma transferência de R${valor} para {destino.titular} ");
                return true;
            }
            else
            {
                return false;
            }
        }


        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Não é possível definir saldo com valores negativos.");
                return;
            }
            else
            {
               this.saldo = valor;
            }
        }


        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numeroAgencia, string numeroConta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = numeroConta;
            if (numeroAgencia <= 0)
            {
                throw new ArgumentException 
                    ("Número de agência menor ou igual a zero", nameof(numeroAgencia));
            }

            /*
            try
            {
                TaxaOperacao = 30 / TotalContas;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível realizar uma divisão por zero.");
            }
            */

            TotalContas++;
        }

 
    }
}
