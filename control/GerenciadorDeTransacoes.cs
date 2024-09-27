using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVVFintech.model;

namespace UVVFintech.control
{
    internal class GerenciadorDeTransacoes
    {
        public void ExecutarTransacao(ITransacao t, double v)
        {
            if (t == null)
            {
                throw new ArgumentNullException("t");
            }
            else
            {
                Console.WriteLine("Execucao");
            }
        }
    }
}
