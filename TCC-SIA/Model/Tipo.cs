using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Tipo
    {
        private string nomeTipo;

        public string getNomeTipo() {  return nomeTipo; }

        public void setNomeTipo(string nomeTipo)
        {
            this.nomeTipo = nomeTipo;
        }
    }
}
