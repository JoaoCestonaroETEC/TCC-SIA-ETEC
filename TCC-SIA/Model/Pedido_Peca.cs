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
        private long idPeca;
        private long quantVezes;
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

        public long getQuantVezes()
        {
            return quantVezes;
        }

        public void setQuantVezes(long quantVezes)
        {
            this.quantVezes = quantVezes;
        }
       
        #endregion
    }
}
