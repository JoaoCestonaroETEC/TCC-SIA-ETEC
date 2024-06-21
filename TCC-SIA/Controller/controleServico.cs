using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controleServico
    {
        public string cadastroServico(Servico mServico)
        {
            string sql = "INSERT INTO SERVICO(NOMESERVICO, DESCSERVICO, VALORSERVICO, GARANTIASERVICO) " + "values(@NOMESERVICO, @DESCSERVICO, @VALORSERVICO, @GARANTIASERVICO);";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@NOMESERVICO", mServico.getNomeServico());
                comm.Parameters.AddWithValue("@GARANTIASERVICO", mServico.getGarantiaServico());
                comm.Parameters.AddWithValue("@DESCSERVICO", mServico.getDescServico());
                comm.Parameters.AddWithValue("@VALORSERVICO", mServico.getValorServico());

                comm.ExecuteNonQuery();
                return "Serviço cadastrado com sucesso!";
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
