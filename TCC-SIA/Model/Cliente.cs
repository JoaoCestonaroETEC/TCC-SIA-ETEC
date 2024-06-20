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
        private long cpfCliente;
        private string nomeCliente;
        private string emailCliente;
        private string senhaCliente;
        private string telefoneCliente;
        private DateTime datanascCliente;

        //Método para definir o cpf do cliente
        public long getCpfCliente()
        {
            return this.cpfCliente;
        }

        // Método para definir o nome do cliente
        public void setCpfCliente(long cpfCliente)
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

        // Método para obter o telefone do cliente
        public string getTelefoneCliente()
        {
            return this.telefoneCliente;
        }

        // Método para definir o telefone do cliente
        public void getTelefoneCliente(string telefoneCliente)
        {
            this.telefoneCliente = telefoneCliente;
        }

        // Método para obter a data de nascimento do cliente
        public DateTime getDataNascCliente()
        {
            return this.datanascCliente;
        }

        // Método para definir a data de nascimento do cliente
        public void setDataNascCliente(DateTime datanascCliente)
        {
            this.datanascCliente = datanascCliente;
        }
    }

    
}
