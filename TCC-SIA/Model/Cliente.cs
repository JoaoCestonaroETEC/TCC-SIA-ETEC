using System;
using System.Collections.Generic;
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
        private string senha;

        // Propriedade pública para idCliente
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        // Propriedade pública para emailCliente
        public string EmailCliente
        {
            get { return emailCliente; }
            set { emailCliente = value; }
        }

        // Propriedade pública para senha
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
