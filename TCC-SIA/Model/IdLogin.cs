using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class IdLogin
    {
        #region Criação de atributo
        private string cnpjLogin;
        private string usuarioLogin;
        private string emailLogin;
        private string senhaLogin;
        private string telefoneLogin;
        #endregion

        #region Encapsulamento
        public string getCnpjLogin()
        {
            return this.cnpjLogin;
        }

        public void setCnpjLogin(string cnpjLogin)
        {
            this.cnpjLogin = cnpjLogin;
        }

        public string getUsuarioLogin()
        {
            return this.usuarioLogin;
        }

        public void setUsuarioLogin(string usuarioLogin)
        {
            this.usuarioLogin = usuarioLogin;
        }

        public string getEmailLogin()
        {
            return this.emailLogin;
        }

        public void setEmailLogin(string emailLogin)
        {
            this.emailLogin = emailLogin;
        }

        public string getSenhaLogin()
        {
            return this.senhaLogin;
        }
        public void setSenhaLogin(string senhaLogin)
        {
            this.senhaLogin = senhaLogin;
        }
        #endregion
    }
}
