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
        public void setCnpj(long cnpjLogin)
        {
            this.cnpjLogin = cnpjLogin;
        }

        public string getNome()
        {
            return this.nomeLogin;
        }

        // Método para definir o nome do cliente
        public void setNome(string nomeLogin)
        {
            this.nomeLogin = nomeLogin;
        }

        public string getEmail()
        {
            return this.emailogin;
        }

        // Método para definir o nome do cliente
        public void setEmail(string emailLogin)
        {
            this.emailogin = emailLogin;
        }


        public string getSenha()
        {
            return this.senhaLogin;
        }

        // Método para definir o nome do cliente
        public void setSenha(string senha)
        {
            this.senhaLogin = senhaLogin;
        }

        public long getTelefone()
        {
            return this.telefoneLogin;
        }

        // Método para definir o nome do cliente
        public void setTelefone(long telefoneLogin)
        {
            this.telefoneLogin = telefoneLogin;
        }
    }
}
