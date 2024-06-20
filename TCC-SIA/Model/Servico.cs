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
        private string tipoServico;
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

        public string TipoServico
        {
            get { return tipoServico; }
            set { tipoServico = value; }
        }

        public decimal ValorServico
        {
            get { return valorServico; }
            set { valorServico = value; }
        }
    }
}
