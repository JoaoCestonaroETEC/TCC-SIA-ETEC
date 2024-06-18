using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_SIA.Model
{
    internal class Veiculo
    {
        private int cpfcliente;
        private string cor;
        private string marca;
        private string tipo;
        private string modelo;
        private string placa;

        public int getCpfCliente()
        {
            return this.cpfcliente;
        }

        public void setCpfCliente(int CpfCliente)
        {
            this.cpfcliente = CpfCliente;
        }

        public string getCor()
        {
            return this.cor;
        }

        public void setCor(string Cor)
        {
            this.cor = Cor;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public void setMarca(string Marca)
        {
            this.marca = Marca;
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
