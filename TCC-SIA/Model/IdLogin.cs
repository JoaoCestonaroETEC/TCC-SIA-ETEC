using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class IdLogin
    {
        private string cnpj;
        private string usuario;
        private string email;
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

        public string getEmail()
        {
            return this.email;
        }

        // Método para definir o nome do cliente
        public void setEmail(string Email)
        {
            this.email = Email;
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

        public string getCnpj()
        {
            return this.cnpj;
        }

        public void setCnpj(string Cnpj)
        {
            this.cnpj = Cnpj;
        }
    }
}
