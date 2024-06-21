using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Veiculo
    {
        private long cpfcliente;
        private long idMarca;
        private long idTipo;
        private string cor;
        private string tipo;
        private string modelo;
        private string placa;

        public long getCpfCliente()
        {
            return this.cpfcliente;
        }

        public void setCpfCliente(long CpfCliente)
        {
            this.cpfcliente = CpfCliente;
        }

        public long getIdMarca()
        {
            return this.idMarca;
        }

        public void setIdMarca(long idMarca)
        {
            this.idMarca = idMarca;
        }

        public long getIdTipo()
        {
            return this.idTipo;
        }

        public void setIdTipo(long idTipo)
        {
            this.idTipo = idTipo;
        }

        public string getCor()
        {
            return this.cor;
        }

        public void setCor(string Cor)
        {
            this.cor = Cor;
        }

        public string getTipo()
        {
            return this.tipo;
        }

        public void setTipo(string Tipo)
        {
            this.tipo = Tipo;
        }

        public string getModelo()
        {
            return this.modelo;
        }

        public void setModelo(string Modelo)
        {
            this.modelo = Modelo;
        }

        public string getPlaca()
        {
            return this.placa;
        }

        public void setPlaca(string Placa)
        {
            this.placa = Placa;
        }
    }
}
