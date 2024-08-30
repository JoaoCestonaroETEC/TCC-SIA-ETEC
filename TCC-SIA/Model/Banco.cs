using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Banco
    {
        #region Criação de atributo
        private string server;
        private int port;
        private string user;
        private string senha;
        private string banco;
        #endregion

        #region Encapsulamento
        public string GetServer()
        {
            return this.server;
        }

        public void SetServer(string server)
        {
            this.server = server;
        }

        public int GetPort()
        {
            return this.port;
        }

        public void SetPort(int port)
        {
            this.port = port;
        }

        public string GetUser()
        {
            return this.user;
        }

        public void SetUser(string user)
        {
            this.user = user;
        }

        public string GetSenha()
        {
            return this.senha;
        }

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetBanco()
        {
            return this.banco;
        }

        public void SetBanco(string banco)
        {
            this.banco = banco;
        }
        #endregion
    }
}
