using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Marca
    {
        #region Criação de atributo
        private long idMarca;
        private string nomeMarca;
        private string descMarca;
        private string tipoMarca;
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

        public string getNomeMarca() 
        {  
            return nomeMarca; 
        }
        public void setNomeMarca(string nomeMarca)
        {
            this.nomeMarca = nomeMarca;
        }

        public string getDescMarca()
        {
            return descMarca;
        }

        public void setDescMarca(string descMarca)
        {
            this.descMarca = descMarca;
        }
        public string getTipoMarca()
        {
            return tipoMarca;
        }
        public void setTipoMarca(string tipomarca)
        {
            this.tipoMarca = tipomarca;
        }
        #endregion

    }
}
