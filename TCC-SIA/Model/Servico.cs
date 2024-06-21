using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Servico
    {
        private string nomeServico;
        private string descServico;
        private DateTime garantiaServico;
        private long valorServico;

        public string getNomeServico()
        {
            return nomeServico;
        }

        public void setNomeServico(string nomeServico)
        {
            this.nomeServico = nomeServico;
        }

        public DateTime getGarantiaServico()
        {
            return garantiaServico;
        }

        public void setGarantiaServico(DateTime garantiaServico)
        {
            this.garantiaServico = garantiaServico;
        }

        public string getDescServico()
        {
            return descServico;
        }

        public void setDescServico(string descServico)
        {
            this.descServico = descServico;
        }

        public long getValorServico()
        {
            return valorServico;
        }

        public void setValorServico(long valorServico)
        {
            this.valorServico = valorServico;
        }
    }
}
