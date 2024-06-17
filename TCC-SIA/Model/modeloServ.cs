using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class modeloServ
    {
        private int IdServ;
        private string nomeServ;
        private decimal valorServ;

        #region Encapsulamento 
        public int getIdServ() 
        {
            return this.IdServ;
        }
        public void setIdServ(int idServ)
        {
            this.IdServ = idServ;
        }

        public string getNomeServ()
        {
            return this.nomeServ;
        }
        public void setNomeServ(string nomeServ)
        {
            this.nomeServ = nomeServ;
        }

        public double getValorServ()
        {
            return this.valorServ;
        }
        public void setValorServ (decimal valorServ)
        {
            this.valorServ = valorServ;
        }
#endregion

    }
}
