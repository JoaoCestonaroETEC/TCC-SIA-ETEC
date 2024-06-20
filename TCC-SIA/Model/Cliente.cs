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
        private int numero;
        private string rua;
        private string bairro;
        private string cidade;
        private int cep;
        private string uf;
        private string sexo;

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
        public void setTelefoneCliente(string telefoneCliente)
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



        // Método para obter o número da casa do cliente
        public int getNumero()
        {
            return this.numero;
        }

        // Método para definir o número da casa do cliente
        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        // Método para obter rua do cliente
        public string getRua()
        {
            return this.rua;
        }

        // Método para definir a rua do cliente
        public void setRua(string rua)
        {
            this.rua = rua;
        }

        // Método para obter o bairro do cliente
        public string getBairro()
        {
            return this.bairro;
        }

        // Método para definir o bairro do cliente
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        // Método para obter a cidade do cliente
        public string getCidade()
        {
            return this.cidade;
        }

        // Método para definir a cidade do cliente
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        // Método para obter o cep do cliente
        public int getCep()
        {
            return this.cep;
        }

        // Método para definir o cep do cliente
        public void setCep(int cep)
        {
            this.cep = cep;

        }

        // Método para obter a uf(Estado) do cliente
        public string getUf()
        {
            return this.uf;
        }

        // Método para definir o uf(Estado) do cliente
        public void setUf(string uf)
        {
            this.uf = uf;
        }

        // Método para obter o sexo do cliente
        public string getSexo()
        {
            return this.sexo;
        }

        // Método para definir o sexo do cliente
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
    }

}