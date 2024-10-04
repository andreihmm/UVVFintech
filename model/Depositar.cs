using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintech.model
{
    internal class Depositar : ITransacao
    {
        private Conta conta {  get; set; }

        public void fazerTransacao(double v)
        {
            depositar(v);
        }

        public void depositar(double v) 
        {
            conta.saldo = conta.saldo + v;
        }
    }
}
