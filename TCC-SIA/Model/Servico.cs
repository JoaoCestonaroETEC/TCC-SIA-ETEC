using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    public class Servico
    {
        #region Criação de atributo
        private long idServico;
        private string nomeServico;
        private string descServico;
        private decimal valorServico;
        private DateTime garantiaServico;
        private string funcionario;
        private long quantVezes;
        #endregion

        #region Encapsulamento

        public long getIDServico()
        {
            return idServico;
        }
        public void setIDServico(long idServico)
        {
            this.idServico = idServico;
        }

        public string getNomeServico()
        {
            return nomeServico;
        }

        public void setNomeServico(string nomeServico)
        {
            this.nomeServico = nomeServico;
        }

        public string getDescServico()
        {
            return descServico;
        }

        public void setDescServico(string descServico)
        {
            this.descServico = descServico;
        }

        public decimal getValorServico()
        {
            return valorServico;
        }

        public void setValorServico(decimal valorServico)
        {
            this.valorServico = valorServico;
        }

        public DateTime getGarantiaServico()
        {
            return garantiaServico;
        }
        public void setGarantiaServico(DateTime garantiaServico)
        {
            this.garantiaServico = garantiaServico;
        }
        public string getFuncionario()
        {
            return funcionario;
        }

        public void setFuncionario(string funcionario)
        {
            this.funcionario = funcionario;
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
