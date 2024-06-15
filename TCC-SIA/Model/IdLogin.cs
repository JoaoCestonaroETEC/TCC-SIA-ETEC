using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class IdLogin
    {
        private long cnpj;
        private string usuario;
        private string senha;

        // Propriedade automática para idCliente
        public string getUsuario()
        {
            return this.usuario;
        }

        // Método para definir o nome do cliente
        public void setUsuario(string Usuario)
        {
            this.usuario = Usuario;
        }

        // Método para obter o email do cliente
        public string getSenha()
        {
            return this.senha;
        }

        // Método para definir o email do cliente
        public void setSenha(string Senha)
        {
            this.senha = Senha;
        }

        public long getCnpj()
        {
            return this.cnpj;
        }

        public void setCnpj(long Cnpj)
        {
            this.cnpj = Cnpj;
        }
    }
}
