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
        private long telefone;

        public long getCnpj()
        {
            return this.cnpjLogin;
        }

        public void setCnpj(long cnpjLogin)
        {
            this.cnpjLogin = cnpjLogin;
        }

        public string getNome()
        {
            return this.nomeLogin;
        }

        public void setNome(string nomeLogin)
        {
            this.nomeLogin = nomeLogin;
        }

        public string getEmail()
        {
            return this.emailogin;
        }

        public void setEmail(string emailLogin)
        {
            this.emailogin = emailLogin;
        }


        public string getSenha()
        {
            return this.senhaLogin;
        }

        public void setSenha(string senha)
        {
            this.senhaLogin = senhaLogin;
        }

        public long getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(long telefone)
        {
            this.telefone = telefone;
        }
    }
}
