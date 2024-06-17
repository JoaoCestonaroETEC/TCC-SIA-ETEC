using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class CadastroLogin
    {
        private string cnpjLogin;
        private string senhaLogin;
        private string nomeLogin;

        public string getCnpj()
        {
            return this.cnpjLogin;
        }

        // Método para definir o nome do cliente
        public void setCnpj(string Cnpj)
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

        public string getSenha()
        {
            return this.senhaLogin;
        }

        // Método para definir o nome do cliente
        public void setSenha(string Senha)
        {
            this.senhaLogin = Senha;
        }
    }
}
