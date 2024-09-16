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
        #region Criação de atributo
        private int idCliente;
        private string cpfCliente;
        private string cnpjCliente;
        private string nomeCliente;
        private string emailCliente;
        private DateTime datanascCliente;
        private string sexo;
        private long numero;
        private string rua;
        private string cidade;
        private long cep;
        private string bairro;
        private string uf;
        private string telefone;
        private string status;
        private DateTime data;
        private string obs;
        private string razao;
        #endregion

        #region Encapsulamento
        public int getIDCliente()
        {
            return this.idCliente;
        }

        public void setIDCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }

        public string getCpfCliente()
        {
            return this.cpfCliente;
        }

        public void setCpfCliente(string cpfCliente)
        {
            this.cpfCliente = cpfCliente;
        }
        public string getCNPJCliente()
        {
            return this.cnpjCliente;
        }

        public void setCNPJCLiente(string cnpjCliente)
        {
            this.cnpjCliente = cnpjCliente;
        }
        public string getNomeCliente()
        {
            return this.nomeCliente;
        }

        public void setNomeCliente(string nomeCliente)
        {
            this.nomeCliente = nomeCliente;
        }

        public string getEmailCliente()
        {
            return this.emailCliente;
        }

        public void setEmailCliente(string emailCliente)
        {
            this.emailCliente = emailCliente;
        }

        public DateTime getDataNascCliente()
        {
            return this.datanascCliente;
        }

        public void setDataNascCliente(DateTime datanascCliente)
        {
            this.datanascCliente = datanascCliente;
        }

        public string getSexo()
        {
            return this.sexo;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public long getNumero()
        {
            return this.numero;
        }

        public void setNumero(long numero)
        {
            this.numero = numero;
        }

        public string getRua()
        {
            return this.rua;
        }

        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public string getCidade()
        {
            return this.cidade;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public long getCep()
        {
            return this.cep;
        }

        public void setCep(long cep)
        {
            this.cep = cep;

        }

        public string getBairro()
        {
            return this.bairro;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string getUf()
        {
            return this.uf;
        }

        public void setUf(string uf)
        {
            this.uf = uf;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getStatus()
        {
            return this.status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }
        public DateTime getData()
        {
            return this.data;
        }

        public void setData(DateTime data)
        {
            this.data = data;
        }
        public string getObs()
        {
            return this.obs;
        }

        public void setObs(string obs)
        {
            this.obs = obs;
        }

        public string getRazao()
        {
            return this.razao;
        }
        public void setRazao(string razao)
        {
            this.razao = razao;
        }
        #endregion
    }

}