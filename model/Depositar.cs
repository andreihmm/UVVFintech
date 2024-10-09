using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintech.model
{
    internal class Depositar : ITransacao
    {
        private Conta conta;

        public Depositar(Conta conta)
        {
            this.conta = conta;
        }

        public void fazerTransacao(double valor)
        {
            DepositarValor(valor);
        }

        private void DepositarValor(double valor)
        {
            conta.Depositar(valor); // Chama o método público para depositar
        }
    }

}
