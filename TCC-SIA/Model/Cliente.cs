using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Cliente
    {
        private int idCliente;
        private string nomeCliente;
        private string emailCliente;
        private string senhaCliente;

        // Propriedade automática para idCliente
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        // Propriedade automática para emailCliente
        public string EmailCliente { get; set; }

        // Propriedade automática para senha
        public string Senha { get; set; }
    }

    
}
