using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Servico
    {
        private int idPeca;
        private int idVeiculo;
        private string nomeServico;
        private string descServico;
        private string tipoServico;
        private long valorServico;
        private DateTime dataServico;

        public int getIdPeca()
        {
            return idPeca;
        }

        public void setIdPeca(int idPeca)
        {
            this.idPeca = idPeca;
        }

        public int getIdVeiculo()
        {
            return idVeiculo;
        }

        public void setIdVeiculo(int idVeiculo)
        {
            this.idVeiculo = idVeiculo;
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



        public string TipoServico
        {
            get { return TipoServico; }
            set { TipoServico = value; }
        }

    }
}
