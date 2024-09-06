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
        private long idcliente;
        private long idMarca;
        private string nomeVeiculo;
        private string tipoVeiculo;
        private string corVeiculo;
        private string placaVeiculo;
        private string modeloVeiculo;

        private string chassi;
        private DateTime anoFabricacao;
        private long quilometragem;
        private string motor;
        private string combustivel;
        private DateTime data;
        private long seguro;
            
        #endregion

        #region Encapsulamento
        public long getIdCliente()
        {
            return this.idcliente;
        }

        public void setIdCliente(long idcliente)
        {
            this.idcliente = idcliente;
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
        public string getChassi()
        {
            return this.chassi;
        }

        public void setChassi(string chassi)
        {
            this.chassi = chassi;
        }

        public DateTime getAnoFabricacao()
        {
            return this.anoFabricacao;
        }

        public void setAnoFabricacao(DateTime anoFabricacao)
        {
            this.anoFabricacao = anoFabricacao;
        }

        public long getQuilometragem()
        {
            return this.quilometragem;
        }

        public void setQuilometragem(long quilometragem)
        {
            this.quilometragem = quilometragem;
        }

        public string getMotor()
        {
            return this.motor;
        }

        public void setMotor(string motor)
        {
            this.motor = motor;
        }

        public string getCombustivel()
        {
            return this.combustivel;
        }

        public void setCombustivel(string combustivel)
        {
            this.combustivel = combustivel;
        }

        public DateTime getData()
        {
            return this.data;
        }

        public void setData(DateTime data)
        {
            this.data = data;
        }

        public long getSeguro()
        {
            return this.seguro;
        }

        public void setSeguro(long seguro)
        {
            this.seguro = seguro;
        }
        #endregion
    }
}
