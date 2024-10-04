using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintech.model
{
    internal class Sacar : ITransacao
    {
        private Conta conta {  get; set; }

        public void fazerTransacao(double v)
        {
            sacar(v);
        }

        public void sacar(double v) {
            conta.saldo = conta.saldo - v;
        }
    }
}
