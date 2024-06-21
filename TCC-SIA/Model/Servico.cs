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
        private decimal valorServico;

        public string NomeServico
        {
            get { return nomeServico; }
            set { nomeServico = value; }
        }

        public string DescServico
        {
            get { return descServico; }
            set { descServico = value; }
        }

        public DateTime GarantiaServico
        {
            get { return garantiaServico; }
            set { GarantiaServico = value; }
        }

        public decimal ValorServico
        {
            get { return valorServico; }
            set { valorServico = value; }
        }
    }
}
