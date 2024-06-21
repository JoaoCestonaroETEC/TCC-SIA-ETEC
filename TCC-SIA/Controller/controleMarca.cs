using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controleMarca
    {
        public string cadastroMarca(Marca mMarca)
        {
            string sql = "INSERT INTO MARCA(NOMEMARCA, DESCMARCA) " + "values(@NOMEMARCA, @DESCMARCA);";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@NOMEMARCA", mMarca.getNomeMarca());
                comm.Parameters.AddWithValue("@DESCMARCA", mMarca.getDescMarca());

                comm.ExecuteNonQuery();
                return "Marca cadastrada com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
            finally
            {
                con.desconectar();
            }
        }
    }
}
