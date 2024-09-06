﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Peca
    {
        #region Criação de atributo
        private long idPeca;
        private long idMarca;
        private string nomePeca;
        private string tipoPeca;
        private string descPeca;
        private decimal valorPeca;
        private int unidade;
        private int quantPeca;
        private DateTime garantiaPeca;
        public string fornecedor;
        public DateTime dataAquisicao;
        #endregion

        #region Encapsulamento

        public long getIdPeca()
        {
            return idPeca;
        }
        public void setIdPeca(long idPeca)
        {
            this.idPeca = idPeca;
        }

        public long getIdMarca()
        {
            return idMarca;
        }

        public void setIdMarca(long idMarca)
        {
            this.idMarca = idMarca;
        }

        public string getNomePeca()
        {
            return nomePeca;
        }

        public void setNomePeca(string nomePeca)
        {
            this.nomePeca = nomePeca;
        }

        public string getTipoPeca()
        {
            return this.tipoPeca;
        }
        public void setTipoPeca(string tipoPeca)
        {
            this.tipoPeca = tipoPeca;
        }

        public string getDescPeca()
        {
            return descPeca;
        }

        public void setDescPeca(string descPeca)
        {
            this.descPeca = descPeca;
        }

        public decimal getValorPeca()
        {
            return valorPeca;
        }

        public void setValorPeca(decimal valorPeca)
        {
            this.valorPeca = valorPeca;
        }
        public int getUnidade()
        {
            return unidade;
        }

        public void setUnidade(int unidade)
        {
            this.unidade = unidade;
        }
        public int getQuantPeca()
        {
            return quantPeca;
        }

        public void setQuantPeca(int quantPeca)
        {
            this.quantPeca = quantPeca;
        }
        public DateTime getGarantiaPeca()
        {
            return garantiaPeca;
        }

        public void setGarantiaPeca(DateTime garantiaPeca)
        {
            this.garantiaPeca = garantiaPeca;
        }
        public string getFornecedor()
        {
            return fornecedor;
        }

        public void setFornecedor(string fornecedor)
        {
            this.fornecedor = fornecedor;
        }
        public DateTime getDataAquisicao()
        {
            return dataAquisicao;
        }

        public void setDataAquisao(DateTime dataAquisicao)
        {
            this.dataAquisicao = dataAquisicao;
        }
        #endregion
    }
}
