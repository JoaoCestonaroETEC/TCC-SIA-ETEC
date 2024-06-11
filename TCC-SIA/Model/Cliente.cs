using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;

namespace TCC_SIA.Model
{
    internal class Cliente
    {
        private string cpfCliente;
        private string nomeCliente;
        private string emailCliente;
        private string senhaCliente;
        private string telefoneCliente;
        private string datanascCliente;

        //Método para definir o cpf do cliente
        public string getCpfCliente()
        {
            return this.cpfCliente;
        }

        // Método para definir o nome do cliente
        public void setCpfCliente(string cpfCliente)
        {
            this.cpfCliente = cpfCliente;
        }
        // Propriedade automática para idCliente
        public string getNomeCliente()
        {
            return this.nomeCliente;
        }

        // Método para definir o nome do cliente
        public void setNomeCliente(string nomeCliente)
        {
            this.nomeCliente = nomeCliente;
        }

        // Método para obter o email do cliente
        public string getEmailCliente()
        {
            return this.emailCliente;
        }

        // Método para definir o email do cliente
        public void setEmailCliente(string emailCliente)
        {
            this.emailCliente = emailCliente;
        }

        // Método para obter a senha do cliente
        public string getSenhaCliente()
        {
            return this.senhaCliente;
        }

        // Método para definir a senha do cliente
        public void setSenhaCliente(string senhaCliente)
        {
            this.senhaCliente = senhaCliente;
        }
    }

    
}
