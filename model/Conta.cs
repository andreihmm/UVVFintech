using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintech.model
{
    internal abstract class Conta
    {
        private Cliente titular {  get; set; }

        private double saldo = 0;

        public double GetSaldo()
        {
            return saldo;
        }

        private int id { get; set; }

        public abstract void cobrarTaxa();


        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                return true; // Saque realizado com sucesso
            }
            return false; // Saque não realizado (valor inválido ou saldo insuficiente)
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Depósito realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Falha no depósito. O valor deve ser positivo.");
            }
        }
    }
}
