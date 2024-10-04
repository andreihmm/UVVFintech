using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVVFintech.control;

namespace UVVFintech.model
{
    internal class Banco
    {
        private String agencia {  get; set; }
        private String nome { get; set; }

        private GerenciadorDeClientes gerenciadorCli { get; set; }
        private GerenciadorDeTransacoes gerenciadorTrans { get; set; }
        private GerenciadorDeContas gerenciadorConta { get; set; }

    }
}
