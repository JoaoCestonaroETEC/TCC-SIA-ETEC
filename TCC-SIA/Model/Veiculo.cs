using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Veiculo
    {
        #region Criação de atributo
        private string cpfcliente;
        private long idMarca;
        private string nomeVeiculo;
        private string tipoVeiculo;
        private string corVeiculo;
        private string placaVeiculo;
        private string modeloVeiculo;
        #endregion

        #region Encapsulamento
        public string getCpfCliente()
        {
            return this.cpfcliente;
        }

        public void setCpfCliente(string cpfCliente)
        {
            this.cpfcliente = cpfCliente;
        }

        public long getIdMarca()
        {
            return this.idMarca;
        }

        public void setIdMarca(long idMarca)
        {
            this.idMarca = idMarca;
        }

        public string getNomeVeiculo()
        {
            return this.nomeVeiculo;
        }

        public void setNomeVeiculo(string nomeVeiculo)
        {
            this.nomeVeiculo = nomeVeiculo;
        }
        public string getTipoVeiculo()
        {
            return this.tipoVeiculo;
        }

        public void setTipoVeiculo(string tipoVeiculo)
        {
            this.tipoVeiculo = tipoVeiculo;
        }

        public string getCorVeiculo()
        {
            return this.corVeiculo;
        }

        public void setCorVeiculo(string corVeiculo)
        {
            this.corVeiculo = corVeiculo;
        }
        public string getPlacaVeiculo()
        {
            return this.placaVeiculo;
        }

        public void setPlacaVeiculo(string placaVeiculo)
        {
            this.placaVeiculo = placaVeiculo;
        }

        public string getModeloVeiculo()
        {
            return this.modeloVeiculo;
        }

        public void setModeloVeiculo(string modeloVeiculo)
        {
            this.modeloVeiculo = modeloVeiculo;
        }
        #endregion
    }
}
