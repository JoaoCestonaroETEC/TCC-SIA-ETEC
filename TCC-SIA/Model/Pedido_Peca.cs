using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    public class Pedido_Peca
    {
        #region Criação de atributo
        private long idMarca;
        private string nomePeca;
        private string tipoPeca;
        private string descPeca;
        private decimal valorPeca;
        private int quantPeca;
        private DateTime garantiaPeca;
        #endregion

        #region Encapsulamento
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
        #endregion
    }
}
