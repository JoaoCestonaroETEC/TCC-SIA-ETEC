using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controleTipo
    {
        public string cadastroTipo(Tipo mTipo)
        {
            string sql = "INSERT INTO TIPO(NOMETIPO) " + "values(@NOMETIPO);";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@NOMETIPO", mTipo.getNomeTipo());

                comm.ExecuteNonQuery();
                return "Tipo cadastrado com sucesso!";
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
