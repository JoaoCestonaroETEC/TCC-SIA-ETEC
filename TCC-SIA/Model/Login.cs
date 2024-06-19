using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class LoginEmpresa
    {
        private long cnpjLogin;
        private string emailogin;
        private string senhaLogin;
        private string nomeLogin;
        private long telefoneLogin;

        public long getCnpj()
        {
            return this.cnpjLogin;
        }

        // Método para definir o nome do cliente
        public void setCnpj(long Cnpj)
        {
            this.cnpjLogin = Cnpj;
        }

        public string getNome()
        {
            return this.nomeLogin;
        }

        // Método para definir o nome do cliente
        public void setNome(string Nome)
        {
            this.nomeLogin = Nome;
        }

        public string getEmail()
        {
            return this.emailogin;
        }

        // Método para definir o nome do cliente
        public void setEmail(string Email)
        {
            this.emailogin = Email;
        }


        public string getSenha()
        {
            return this.senhaLogin;
        }

        // Método para definir o nome do cliente
        public void setSenha(string Senha)
        {
            this.senhaLogin = Senha;
        }

        public long getTelefone()
        {
            return this.telefoneLogin;
        }

        // Método para definir o nome do cliente
        public void setTelefone(long Telefone)
        {
            this.telefoneLogin = Telefone;
        }
    }
}
