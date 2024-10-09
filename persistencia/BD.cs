using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVVFintech.model;
using System.IO;
using System.Text.Json;


namespace UVVFintech.persistencia
{
    internal class BD
    {
        private List<Cliente> clientes;

        public void salvarBD(Cliente cliente)
        {
            clientes.Add(cliente);
            var jsonData = JsonSerializer.Serialize(clientes);
            File.WriteAllText("clientes.json", jsonData);
        }

        public List<Cliente> retornarBD()
        {
            if (File.Exists("clientes.json"))
            {
                var jsonData = File.ReadAllText("clientes.json");
                clientes = JsonSerializer.Deserialize<List<Cliente>>(jsonData);
            }
            return clientes;
        }

        public Cliente retornarBD(String CPF)
        {
            return clientes.FirstOrDefault(c => c.getCPF() == CPF);
        }

        public void removerBD(String CPF)
        {
            var cliente = clientes.FirstOrDefault(c => c.getCPF() == CPF);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                var jsonData = JsonSerializer.Serialize(clientes);
                File.WriteAllText("clientes.json", jsonData);
            }
        }


        public bool existe(String CPF)
        {
            return clientes.Any(c => c.getCPF() == CPF);
        }

    }
}
