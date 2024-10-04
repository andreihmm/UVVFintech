using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVVFintech.model;

namespace UVVFintech.persistencia
{
    internal class BD
    {
        private List<Cliente> clientes;

        public void salvarBD(Cliente cliente)
        {

        }

        public List<Cliente> retornarBD()
        {
            return clientes;
        }

        public Cliente retornarBD(String CPF)
        {
            return clientes
        }

        public void removerBD(String CPF) {
        
        }

        public bool existe(String CPF) {
            return false;
        }
    }
}
