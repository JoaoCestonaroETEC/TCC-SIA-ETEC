using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Pedido
    {
        int idPedido;
        string placa;
        string modelo;
        string veiculo;
        string servico;
        string pecas;
        long valorTotal;
        string formaPagamento;
        string observacao;
        long valorTotalPeca;
        long valorTotalServico;

        #region Encapsulamento

        public int getIdPedido()
        {
            return idPedido;
        }
        public void setIdPedido(int idPedido)
        {
            this.idPedido = idPedido;
        }

        public string getPlaca()
        {
            return placa;
        }
        public void setPlaca(string placa)
        {
            this.placa = placa;
        }
        public string getModelo()
        {
            return modelo;
        }
        public void setModelo(string placa)
        {
            this.modelo = modelo;
        }
        public string getVeiculo()
        {
            return veiculo;
        }

        public void setVeiculo(string veiculo)
        {
            this.veiculo = veiculo;
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

        public long getValorTotal()
        {
            return valorTotal;
        }

        public void setTotalValor(long valorTotal)
        {
            this.valorTotal = valorTotal;
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
        #endregion
    }
}
