using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;

namespace TCC_SIA.Model
{
    internal class ClienteF
    {
        #region Criação de atributo
        private int idClienteF;
        private string cpfClienteF;
        private string cnpjClienteF;
        private string nomeClienteF;
        private string emailClienteF;
        private DateTime datanascClienteF;
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
        private string obsF;
        #endregion

        #region Encapsulamento
        public int getIDClienteF()
        {
            return this.idClienteF;
        }

        public void setIDClienteF(int idClienteF)
        {
            this.idClienteF = idClienteF;
        }

        public string getCpfClienteF()
        {
            return this.cpfClienteF;
        }

        public void setCpfClienteF(string cpfClienteF)
        {
            this.cpfClienteF = cpfClienteF;
        }
        public string getCNPJClienteF()
        {
            return this.cnpjClienteF;
        }

        public void setCNPJCLienteF(string cnpjClienteF)
        {
            this.cnpjClienteF = cnpjClienteF;
        }
        public string getNomeClienteF()
        {
            return this.nomeClienteF;
        }

        public void setNomeClienteF(string nomeClienteF)
        {
            this.nomeClienteF = nomeClienteF;
        }

        public string getEmailClienteF()
        {
            return this.emailClienteF;
        }

        public void setEmailClienteF(string emailClienteF)
        {
            this.emailClienteF = emailClienteF;
        }

        public DateTime getDataNascClienteF()
        {
            return this.datanascClienteF;
        }

        public void setDataNascClienteF(DateTime datanascClienteF)
        {
            this.datanascClienteF = datanascClienteF;
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
        public string getObsF()
        {
            return this.obsF;
        }

        public void setObsF(string obsF)
        {
            this.obsF = obsF;
        }
        #endregion
    }

}