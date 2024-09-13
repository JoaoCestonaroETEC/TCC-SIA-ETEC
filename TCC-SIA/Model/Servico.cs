﻿using System;
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
        private string status;
        private decimal desconto_reais;
        private int desconto_porcento;
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
        public string getStatus()
        {
            return status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }
        public decimal getDescontoReais()
        {
            return desconto_reais;
        }

        public void setDescontoReais(decimal descontoReais)
        {
            this.desconto_reais = descontoReais;
        }
        public int getDescontoPorc()
        {
            return desconto_porcento;
        }

        public void setDescontoPorc(int descontoPorc)
        {
            this.desconto_porcento = descontoPorc;
        }
        #endregion
    }
}
