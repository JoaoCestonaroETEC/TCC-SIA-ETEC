using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Pedido
    {
        private int idPedido;
        private string placaVeiculo;
        private string modeloVeiculo;
        private string marcaVeiculo;
        private string tipoVeiculo;
        private string servico;
        private string pecas;
        private decimal valorTotal;
        private string formaPagamento;
        private string observacao;
        private decimal valorTotalPeca;
        private decimal valorTotalServico;
        private string corVeiculo;
        private DateTime dataInicio;
        private DateTime dataFim;
        private int fk_cpfCliente;

        #region Encapsulamento

        public int getIdPedido()
        {
            return idPedido;
        }
        public void setIdPedido(int idPedido)
        {
            this.idPedido = idPedido;
        }

        public string getPlacaVeiculo()
        {
            return placaVeiculo;
        }
        public void setPlacaVeiculo(string placaVeiculo)
        {
            this.placaVeiculo = placaVeiculo;
        }
        public string getModeloVeiculo()
        {
            return modeloVeiculo;
        }
        public void setModeloVeiculo(string modeloVeiculo)
        {
            this.modeloVeiculo = modeloVeiculo;
        }
        public string getTipoVeiculo()
        {
            return tipoVeiculo;
        }

        public void setTipoVeiculo(string tipoVeiculo)
        {
            this.tipoVeiculo = tipoVeiculo;
        }

        public string getServico()
        {
            return servico;
        }

        public void setServico(string servico)
        {
            this.servico = servico;
        }

        public string getPecas()
        {
            return pecas;
        }

        public void setPecas(string pecas)
        {
            this.pecas = pecas;
        }

        public decimal getValorTotal()
        {
            return valorTotal;
        }

        public void setValorTotal(decimal valorTotal)
        {
            this.valorTotal = valorTotal;
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

        public string getFormaPagamento()
        {
            return formaPagamento;
        }

        public void setFormaPagamento(string formaPagamento)
        {
            this.formaPagamento = formaPagamento;
        }

        public string getObservacao()
        {
            return observacao;
        }

        public void setObservacao(string observacao)
        {
            this.observacao = observacao;
        }

        public string getMarcaVeiculo()
        {
            return marcaVeiculo;
        }

        public void setMarcaVeiculo(string marcaVeiculo)
        {
            this.marcaVeiculo = marcaVeiculo;
        }

        public string getCorVeiculo()
        {
            return corVeiculo;
        }

        public void setCorVeiculo(string corVeiculo)
        {
            this.corVeiculo = corVeiculo;
        }

        public DateTime getDataInicio()
        {
            return this.dataInicio;
        }
        public void setDataInicio(DateTime dataInicio)
        {
            this.dataInicio = dataInicio;
        }

        public DateTime getDataFim()
        {
            return this.dataFim;
        }
        public void setDataFim(DateTime dataFim)
        {
            this.dataFim = dataFim;
        }
        #endregion

        public int getIdCliente()
        {
            return idCliente;
        }
        public void setIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }
    }
}
