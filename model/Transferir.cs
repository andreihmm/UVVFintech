using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintech.model
{
    internal class Transferir : ITransacao
    {
        private Conta contaOrigem;
        private Conta contaDestino;

        public Transferir(Conta origem, Conta destino)
        {
            contaOrigem = origem;
            contaDestino = destino;
        }

        public void fazerTransacao(double valor)
        {
            bool saqueSucesso = TransferirValor(valor);
            if (saqueSucesso)
            {
                Console.WriteLine("Transferência realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("Falha na transferência. Verifique o valor ou saldo da conta de origem.");
            }
        }

        private bool TransferirValor(double valor)
        {
            if (contaOrigem.Sacar(valor)) // Tenta sacar da conta de origem
            {
                contaDestino.Depositar(valor); // Se o saque for bem-sucedido, deposita na conta de destino
                return true;
            }
            return false; // Transferência falhou
        }
    }
}
