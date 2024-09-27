using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVVFintech.model;

namespace UVVFintech.control
{
    internal class GerenciadorDeClientes
    {
        private Cliente modeloPersistenciaCli;

        private List<Cliente> clientes;

        public void adicionarCliente(Cliente cliente) {
        
        }

        public void removerCliente(String cpf)
        {

        }

        public List<Cliente> retornarTodosClientes()
        {
            return clientes;
        }

        public Cliente retornarCli(string cpf)
        {
            return modeloPersistenciaCli;
        }

    }
}
