﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVVFintech.control;

namespace UVVFintech.model
{
    internal class Cliente
    {
        private String nome {  get; set; }
        private String cpf;
        public String getCPF()
        {
            return cpf;
        }
        private DateTime dataNascimento {  get; set; }

        private List<Conta> contas { get; set; }

        private GerenciadorDeTransacoes gerenciador {  get; set; }
        private int senha { get; set; }

    }
}
