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
    }
}
