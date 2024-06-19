using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Peca
    {
        private string nomePeca;
        private string tipoPeca;
        private string descPeca;
        private long valorPeca;
        private int quantPeca;
        private string marcaPeca;

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
            return tipoPeca;
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

        public long getValorPeca()
        {
            return valorPeca;
        }

        public void setValorPeca(long valorPeca)
        {
            this.valorPeca = valorPeca;
        }

        public int getQuantPeca()
        {
            return quantPeca;
        }

        public void setQuantPeca(int quantPeca)
        {
            this.quantPeca = quantPeca;
        }

        public string getMarcaPeca()
        {
            return marcaPeca;
        }

        public void setMarcaPeca(string marcaPeca)
        {
            this.marcaPeca = marcaPeca;
        }
    }
}
