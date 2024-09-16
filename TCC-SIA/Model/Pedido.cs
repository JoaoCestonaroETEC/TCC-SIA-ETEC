using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Pedido
    {
        #region Criação de atributo
        private long idPedido;
        private long idcliente;
        private long idVeiculo;
        private decimal valorTotalPedido;
        private decimal valorTotalPeca;
        private decimal valorTotalServico;
        private string observacao;
        private DateTime dataInicio;
        private DateTime dataFim;
        private int desconto_porcento;
        private decimal desconto_reais;

        #endregion

        #region Encapsulamento
        public long getIdPedido()
        {
            return idPedido;
        }

        public void setIdPedido(long idPedido)
        {
            this.idPedido = idPedido;
        }

        public long getIdCliente()
        {
            return idcliente;
        }
        
        public void setIdCliente(long idcliente)
        {
            this.idcliente = idcliente;
        }
        public long getIdVeiculo()
        {
            return idVeiculo;
        }

        public void setIdVeiculo(long idVeiculo)
        {
            this.idVeiculo = idVeiculo;
        }

        public decimal getValorTotalPedido()
        {
            return valorTotalPedido;
        }

        public void setValorTotalPedido(decimal valorTotalPedido)
        {
            this.valorTotalPedido = valorTotalPedido;
        }

        public decimal getValorTotalPeca()
        {
            return valorTotalPeca;
        }

        public void setValorTotalPeca(decimal valorTotalPeca)
        {
            this.valorTotalPeca = valorTotalPeca;
        }

        public decimal getValorTotalServico()
        {
            return valorTotalServico;
        }

        public void setValorTotalServico(decimal valorTotalServico)
        {
            this.valorTotalServico = valorTotalServico;
        }

        public string getObservacao()
        {
            return observacao;
        }

        public void setObservacao(string observacao)
        {
            this.observacao = observacao;
        }

        public DateTime getDataInicio()
        {
            return dataInicio;
        }

        public void setDataInicio(DateTime dataInicio)
        {
            this.dataInicio = dataInicio;
        }

        public DateTime getDataFim()
        {
            return dataFim;
        }

        public void setDataFim(DateTime dataFim)
        {
            this.dataFim = dataFim;
        }
        public int getDescontoPorCento()
        {
            return desconto_porcento;
        }

        public void setDescontoPorCento(int descontoPorCento)
        {
            this.desconto_porcento = descontoPorCento;
        }

        public decimal getDescontoReais()
        {
            return desconto_reais;
        }

        public void setDescontoReais(decimal descontoReais)
        {
            this.desconto_reais = descontoReais;
        }
        #endregion
    }
}
