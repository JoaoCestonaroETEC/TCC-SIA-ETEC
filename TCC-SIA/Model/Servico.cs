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
        private long valorServico;

        public string NomeServico
        {
            get { return nomeServico; }
            set { NomeServico = value; }
        }

        public string DescServico
        {
            get { return descServico; }
            set { DescServico = value; }
        }

        public string TipoServico
        {
            get { return tipoServico; }
            set { tipoServico = value; }
        }

        public long ValorServico
        {
            get { return valorServico; }
            set { ValorServico = value; }
        }
    }
}
