using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Marca
    {
        private string nomeMarca;
        private string descMarca;

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
    }
}
