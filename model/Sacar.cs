using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintech.model
{
    internal class Sacar : ITransacao
    {
        private Conta conta;

        public Sacar(Conta conta)
        {
            this.conta = conta;
        }

        public void fazerTransacao(double valor)
        {
            bool sucesso = SacarValor(valor);
            if (sucesso)
            {
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Falha no saque. Verifique o valor ou saldo.");
            }
        }

        private bool SacarValor(double valor)
        {
            return conta.Sacar(valor); // Chama o método público
        }
    }


}
