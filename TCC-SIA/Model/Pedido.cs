using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Pedido
    {
        private string servicos;
        private string pecas;

        private long cpfCliente;
        private long idVeiculo;
        private long valorTotalPedido;
        private string observacao;
        private long valorTotalPeca;
        private long valorTotalServico;
        private DateTime dataInicio;
        private DateTime dataFim;

        #region Encapsulamento

        public string getServico()
        {
            return servicos;
        }

        public void setServico(string servicos)
        {
            this.servicos = servicos;
        }

        public string getPecas()
        {
            return pecas;
        }

        public void setPecas(string pecas)
        {
            this.pecas = pecas;
        }




        public long getCpfCliente()
        {
            return cpfCliente;
        }
        public void setCpfCliente(long cpfCliente)
        {
            this.cpfCliente = cpfCliente;
        }

        public long getIdVeiculo()
        {
            return idVeiculo;
        }
        public void setIdVeiculo(long idVeiculo)
        {
            this.idVeiculo = idVeiculo;
        }

        public long getValorTotalPedido()
        {
            return valorTotalPedido;
        }

        public void setValorTotalPedido(long valorTotalPedido)
        {
            this.valorTotalPedido = valorTotalPedido;
        }

        public long getValorTotalPeca()
        {
            return valorTotalPeca;
        }

        public void setValorTotalPeca(long valorTotalPeca)
        {
            this.valorTotalPeca = valorTotalPeca;
        }

        public long getValorTotalServico()
        {
            return valorTotalServico;
        }

        public void setValorTotalServico(long valorTotalServico)
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

        public DateTime getDataInicio ()
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

        #endregion
    }
}
