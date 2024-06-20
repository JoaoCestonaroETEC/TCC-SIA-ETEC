using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class ControleCliente
    {
        public string cadastroCliente(Cliente mCliente)
        {
            string sql = "INSERT INTO CLIENTE(CPFCLIENTE, NOMECLIENTE, EMAILCLIENTE, DATANASC_CLIENTE) " + "values(@CPFCLIENTE, @NOMECLIENTE, @EMAILCLIENTE, @DATANASC_CLIENTE);";

            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                comm.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE", mCliente.getDataNascCliente());

                comm.ExecuteNonQuery();
                return "Cliente cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}
