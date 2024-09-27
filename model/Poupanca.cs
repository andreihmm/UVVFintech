using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintech.model
{
    internal class Poupanca : Conta
    {
        private const double V = 0.1;

        private decimal taxaJuros { get; set; } = (decimal)V;

        public override void cobrarTaxa() {
            
        }
    }
}
