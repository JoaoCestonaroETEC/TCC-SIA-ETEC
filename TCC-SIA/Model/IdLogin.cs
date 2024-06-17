using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class IdLogin
    {
        private string nome_cnpj;
        private string senha;

        // Propriedade automática para idCliente
        public string getNomeCnpj()
        {
            return this.nome_cnpj;
        }

        // Método para definir o nome do cliente
        public void setNomeCnpj(string NomeCnpj)
        {
            this.nome_cnpj = NomeCnpj;
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
    }
}
